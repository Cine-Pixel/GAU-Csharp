using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10 {
    class Program {
        public delegate void delegateName(string message);

        public delegate int delegateNumber();

        //public delegate void Action();

        public delegate Parent covarianceHandler();

        public delegate void contraHandler(Parent kid);

        static void Main(string[] args) {
            #region customDelegates
            //delegateName myDel = new delegateName(Display);
            delegateName myDel = Display;
            myDel += SendMobile;
            myDel += SendMail;

            //myDel("Guten tag!");
            myDel.Invoke("Meeting today");
            myDel -= SendMobile;
            myDel.Invoke("Not important meeting");

            delegateNumber delNum = GetRandNumber;
            delNum += GetActualNumber;

            Console.WriteLine();

            Console.WriteLine(delNum());

            foreach(delegateNumber delItem in delNum.GetInvocationList()) {
                Console.WriteLine(delItem());
            }
            #endregion

            #region builtinDelegates
            Action myAction = Welcome;
            Action<string> myGenericAction = GenericWelcome;
            myGenericAction += GenericCongratz;
            myAction += Congratz;

            myAction();
            myGenericAction("Avee");
            Console.WriteLine();

            Func<int, int, int> someFunc = Add;
            someFunc += Mult;

            foreach(Func<int, int, int> func in someFunc.GetInvocationList()) {
                Console.WriteLine(func(10, 3));
            }

            Predicate<int> myPredicate = IsEven;
            myPredicate += IsOdd;

            foreach(Predicate<int> pred in myPredicate.GetInvocationList()) {
                Console.WriteLine(pred(10));
            }

            Predicate<string> stringPred = IsEmpty;
            Console.WriteLine(stringPred(""));
            #endregion

            #region inheritance
            covarianceHandler myCov = CovarianceMethod;
            myCov();

            Console.WriteLine();

            contraHandler myCont = ContraMethod;
            myCont(new Child());
            #endregion

            Room room = new Room();
            room.onWarmAlert = Alarm;
            room.Temperature = 30;
            room.onWarmAlert(room.Temperature);
            Console.WriteLine();

            Action anonim = () => {
                Console.WriteLine("I'm incognito");
            };
            anonim();
            Console.WriteLine();

            Func<int, int> f = (int x) => {
                Console.WriteLine($"My number {x}");
                return x+1;
            };
            Console.WriteLine(f(5));
            
            Console.ReadLine();
        }

        public static void Alarm(int temp) {
            Console.WriteLine($"It's really hot out here: {temp} degree");
        }

        #region noReturn
        public static void Display(string text) {
            Console.WriteLine($"Display on screen: {text}");
        }

        public static void SendMobile(string output) {
            Console.WriteLine($"Send to mobile: {output}");
        }

        public static void SendMail(string mail) {
            Console.WriteLine($"Send email: {mail}");
        }
        #endregion

        #region return
        public static int GetRandNumber() {
            return new Random().Next(1, 100);
        }

        public static int GetActualNumber() {
            return 5;
        }
        #endregion

        #region genericAction
        public static void Welcome() {
            Console.WriteLine("Greeting my friend");
        }

        public static void Congratz() {
            Console.WriteLine("Congratulations on you wedding");
        }

        public static void GenericWelcome(string text) {
            Console.WriteLine($"Generic welcome {text}");
        }

        public static void GenericCongratz(string text) {
            Console.WriteLine($"Generic congratz {text}");
        }
        #endregion

        #region func
        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Mult(int x, int y) {
            return x * y;
        }
        #endregion

        #region predicat
        public static bool IsEven(int num) {
            return num % 2 == 0;
        }

        public static bool IsOdd(int num) {
            return num % 2 != 0;
        }

        public static bool IsEmpty(string text) {
            return text == "";
        }
        #endregion

        #region inheritance
        public static Child CovarianceMethod() {
            Console.WriteLine("Covariance method");
            return new Child();
        }

        public static void ContraMethod(Parent p) {
            Child kid = p as Child;
            Console.WriteLine("Contra Method");
        }
        #endregion
    }
}

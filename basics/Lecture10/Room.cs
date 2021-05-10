using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10 {
    public class Room {
        private int temperature;

        public Action<int> onWarmAlert;

        public int Temperature {
            get => temperature; 
            set {
                temperature = value;
                if(temperature > 40) {
                    if(onWarmAlert != null) onWarmAlert(temperature);
                }
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace TestXML {
    [XmlRpcUrl("http://localhost:8000")]
    public interface IStateName : IXmlRpcProxy {
        [XmlRpcMethod("getTest")]
        string getTest(); 
    }
}

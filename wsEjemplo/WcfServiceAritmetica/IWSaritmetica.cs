using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceAritmetica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSaritmetica
    {
        [OperationContract]
        clsAritmetica sumar(int numero1, int numbero2);
    }

    [DataContract]
    public class clsAritmetica:BaseRespuesta
    {
        [DataMember]
        public int numeroA { get; set; }

        [DataMember]
        public int numeroB { get; set; }

        [DataMember]
        public int resultado { get; set; }

    }

    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string Mensaje { get; set; }

        [DataMember]
        public string Error { get; set; }

    }
}

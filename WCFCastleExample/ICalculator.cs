using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFCastleExample
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        [WebGet(UriTemplate = "sum/{x}/{y}")]
        double Sum(string x, string y);

        [OperationContract]
        [WebGet(UriTemplate = "difference/{x}/{y}")]
        double Difference(string x, string y);
    }
}

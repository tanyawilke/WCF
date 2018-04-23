using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfCountryService.Service.Contract.Models;

namespace WcfCountryService.Service.Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "Service1", Namespace = "localhost/CountryService/2018/04/20")]
    public interface IService1
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFaultException))]
        [WebInvoke(
            Method = "GET", UriTemplate = "XML/SearchCountry", BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        SearchCountryResponse SearchCountryXML();

        [OperationContract]
        [FaultContract(typeof(ServiceFaultException))]
        [WebInvoke(
            Method = "GET", UriTemplate = "JSON/SearchCountry", BodyStyle = WebMessageBodyStyle.Wrapped,
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        SearchCountryResponse SearchCountryJson();

        [OperationContract]
        [FaultContract(typeof(ServiceFaultException))]
        SearchCountryResponse SearchCountry();
    }
}

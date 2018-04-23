using System;
using System.Runtime.Serialization;

namespace WcfCountryService.Service.Contract
{
    [DataContract]
    public class ServiceFaultException
    {
        [DataMember]
        public string StackTrace { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Source { get; set; }

        //public ServiceFaultExcpetion Detail(string details)
        //{
        //    return ServiceException(details);
        //}

        //private ServiceFaultExcpetion ServiceException(object code)
        //{
        //    ServiceFaultExcpetion response = new ServiceFaultExcpetion();

        //    return response;
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WcfCountryService.Service.Contract.Exceptions;

namespace WcfCountryService.Service.Contract.Models
{
    [DataContract]
    public class BaseResponse
    {
        public BaseResponse()
        {
            ErrorList = new List<ErrorInfoDto>();
        }

        [DataMember(IsRequired = true)]
        public List<ErrorInfoDto> ErrorList { get; set; }
    }
}
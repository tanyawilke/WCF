using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfCountryService.Service.Contract.Models
{
    [DataContract(Name = "Country", Namespace = "localhost/CountryService/2018/04/20")]
    public class CountryDto
    {
        [DataMember(Order = 1, IsRequired = true)]
        public int Id { get; set; }

        [DataMember(Order = 2, IsRequired = true)]
        public string Code { get; set; }

        [DataMember(Order = 3, IsRequired = true)]
        public string Name { get; set; }

        [DataMember(Order = 4, IsRequired = true)]
        public string Currency { get; set; }

        #region IExtensibleDataObject Implementation

        public ExtensionDataObject ExtensionData { get; set; }

        #endregion
    }
}
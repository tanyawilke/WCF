﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using WcfCountryService.Service.Contract;
using WcfCountryService.Service.Contract.Models;

namespace WcfCountryService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public SearchCountryResponse SearchCountry()
        {
            throw new NotImplementedException();
        }

        public SearchCountryResponse SearchCountryJson()
        {
            throw new NotImplementedException();
        }

        public SearchCountryResponse SearchCountryXML()
        {
            throw new NotImplementedException();
        }
    }
}

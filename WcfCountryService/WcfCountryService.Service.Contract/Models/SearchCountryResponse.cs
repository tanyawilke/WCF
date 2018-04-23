using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Web;
using WcfCountryService.Service.Contract.Exceptions;

namespace WcfCountryService.Service.Contract.Models
{
    public class SearchCountryResponse: BaseResponse
    {
        [DataMember(IsRequired = true)]
        public CountryDto Country { get; set; }

        public SearchCountryResponse SearchCountryXml(string code)
        {
            return SearchCountry(code);
        }

        public SearchCountryResponse SearchCountryJson(string code)
        {
            return SearchCountry(code);
        }

        private SearchCountryResponse SearchCountry(string code)
        {
            SearchCountryResponse response = new SearchCountryResponse();

            try
            {
                // Country country = null; // CountryManager.SelectByCode(code);
                string country = string.Empty;

                if (country != "")
                {
                    // response.Country = Mapper
                }
                else
                {
                    response.ErrorList.Add(new ErrorInfoDto
                    {
                        Code = code,
                        Description = "No country code",
                        Group = ErrorGroup.Service,
                        Severity = ErrorSeverity.Information
                    });
                }
            }
            catch (Exception ex)
            {
                // LogHelper.Fatal(Logger, "CountryService", ex);

                //throw new WebFaultException<ServiceFaultExcpetion>(ServiceException, HttpStatusCode.InternalServerError);

                throw new Exception(ex.Message);
            }

            return response;
        }
    }
}
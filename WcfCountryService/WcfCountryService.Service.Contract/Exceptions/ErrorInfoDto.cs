using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfCountryService.Service.Contract.Exceptions
{
    public class ErrorInfoDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public ErrorGroup Group { get; set; }
        public ErrorSeverity Severity { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ContactService
{
    [DataContract]
    public class StatusContract
    {
        [DataMember]
        public string Message { get; set; }
    }
}
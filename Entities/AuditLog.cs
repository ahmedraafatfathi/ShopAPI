using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class AuditLog : BaseEntity
    {
        public string RequestInfo { get; set; }

        public string ResponseInfo { get; set; }

        public string UserInfo { get; set; }

        public LogLevel Level { get; set; }

        public string MSG { get; set; }

    }

}

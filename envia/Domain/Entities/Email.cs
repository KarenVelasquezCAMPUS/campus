using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Email : BaseEntity
    {
        public string Empresarial { get; set; }
        public string Personal { get; set; }
        public string EmailAddress { get; set; }
    }
}
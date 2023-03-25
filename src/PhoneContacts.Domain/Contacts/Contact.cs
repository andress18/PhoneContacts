using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace PhoneContacts.Contacts
{
    public class Contact : Entity<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}

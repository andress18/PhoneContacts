using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace PhoneContacts.Contacts
{
    public class ContactDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}

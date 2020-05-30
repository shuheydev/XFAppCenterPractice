using System;
using System.Collections.Generic;
using System.Text;

namespace XFAppCenterPractice.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();// generates random id
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gamer
    {
        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}

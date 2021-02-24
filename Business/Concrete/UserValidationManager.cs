using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirthYear == 2000 && gamer.FirstName =="Fadime" && gamer.LastName == "DURĞUN" && gamer.NationalIdentity== 12345678910 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

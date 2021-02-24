using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserValidationService
    {
        //List<Gamer> GetList();
        bool Validate(Gamer gamer);
    }
}

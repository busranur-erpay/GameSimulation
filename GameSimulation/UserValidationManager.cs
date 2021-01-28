using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.Birthday==1998 && gamer.FirstName=="Büşra" && gamer.LastName=="Erpay" && gamer.TcNo == 12345)
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

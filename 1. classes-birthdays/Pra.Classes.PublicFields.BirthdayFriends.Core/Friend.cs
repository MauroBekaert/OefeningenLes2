using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.Classes.PublicFields.BirthdayFriends.Core
{
    public class Friend
    {
        private string name;
        private DateTime birthDay;

        public void SetName(string name) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Naam mag niet leeg zijn of enkel uit spaties bestaan");
            }

            this.name = name;         
        }

        public string GetName() 
        {
            return name;
        }


        public void SetBirthDay(DateTime birthDay) 
        {
            if (birthDay > DateTime.Today)
            {
                throw new Exception("De datum kan niet in de toekomst liggen.");
            }
            this.birthDay = birthDay;
        }

        public DateTime GetBirthDay()
        { 
            return birthDay;
        }

        public Friend(string name, DateTime birthDay)
        {
            SetName(name);
            SetBirthDay(birthDay);
        }

        public override string ToString()
        {
            return $"{GetName()}-({GetBirthDay()})";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework19.Utilities.Extentions;
namespace homework19.Models
{
    internal class Person
    {
        private string name;
        private string surname;
        public string Name
        {
            get { return name; }  
            set 
            {
                name = value.Capitalized();
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value.Capitalized();
            }
        }
        public int Age { get; set; }
    }
}

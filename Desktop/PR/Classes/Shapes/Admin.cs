using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Admin
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cellphone { get; set; }
        public string AccessID { get; set; }
        public string Gender { get; set; }
        public string RoleName { get; set; }

        public Admin() 
        { 
        }  
    public Admin (string firstname, string lastname, string cellphone) 
        {
            FirstName = firstname;
            LastName = lastname;
            Cellphone = cellphone; ;
        }


    }
        
}

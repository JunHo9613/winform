using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class user
    {
        
        string name;
        string id;
        string password;
        string tel;

        public user()
        {
            name = "";
            id = "";
            password = "";
            tel = "";
           

        }
        public void setName(string s)
        {
            { name = s; }
        }
        public string getName()
        {
            return name;
        }
        public void setID(string s)
        {
            { id = s; }
        }
        public void setPASS(string s)
        {
            { password = s; }
        }
        public string getID()
        {
            return id;
        }
        public string getPASS()
        {
            return password;
        }
        public void setTEL(string s)
        {
            { tel = s; }
        }
        public string getTEL()
        {
            return tel;
        }
        
     
    }
    
}

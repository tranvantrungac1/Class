using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Employee
    {
        private String no;
        private String name;
        private String email;
        private Boolean isManager;
        private String password;


        public Employee()
        {
        }
        public Employee(string no, string name, string email, bool  isManager, string password)
        {
            this.no = no;
            this.name = name;
            this.email = email;
            this.isManager = isManager;
            this.password = password;
        }
        public Boolean GetIsManager()
        {
            return this.isManager;
        }
        public String GetPassword()
        {
            return this.password;
        }
        public String GetName()
        {
            return this.name;
        }
        public String GetNo()
        {
            return this.no;
        }
        public String GetMail()
        {
            return this.email;
        }
        public void SetName(String name)
        {
            this.name=name;
        }
        public void SetNo(String no)
        {
            this.no = no;
        }
        public void SetMail(String mail)
        {
            this.email = mail;
        }
        public override string? ToString()
        {
            return no + ", " + name + ", " + email;
        }
    } 
}

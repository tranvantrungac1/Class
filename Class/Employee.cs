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

        public Employee()
        {
        }
        public Employee(string no, string name, string email)
        {
            this.no = no;
            this.name = name;
            this.email = email;
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

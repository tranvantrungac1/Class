using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class EmployeeManager : BaseManager
    {
        public static int MAX = 10;
        private Employee[] employees;
        public EmployeeManager() : base()
        {
            //this.employees = new Employee[MAX];
            this.employees = new Employee[]{
                new Employee("E001", "hoangnm", "hoangnm@gmail.com", true, "123"),
                new Employee("E002", "namph", "namph@gmail.com", false, "123"),
                new Employee("E003", "minhnv", "minhnv @gmail.com", true, "123"),
            };
        }

        public EmployeeManager(String name, Employee[] employees) : base(name)
        {
            this.employees = employees;
        }

        //public void viewall()
        //{
        //    console.writeline("viewall");
        //    console.writeline("basemanager.version");

        //    base.addnew();
        //}


        public override void Import()
        {
            Console.WriteLine("Hay nhap duong dan toi file can Import");
            String path = Console.ReadLine();
            StreamReader reader = new StreamReader(path);
            
            try
            {
                do 
                {
                    string line = reader.ReadLine();

                    //tách chuỗi gán vào mảng 
                    string[] strings = line.Split(',');

                    //
                    Employee[] newArray = new Employee[this.employees.Length + 1];
                    for (int i = 0; i < this.employees.Length; i++)
                    {
                        newArray[i] = this.employees[i];
                    }
                    String no = strings[0];
                    String name = strings[1];
                    String email = strings[2];
                    Boolean isManager;
                    if (strings[3] == "true")
                    {
                        isManager = true;
                    }
                    else
                    {
                        isManager = false;
                    }
                    String password = strings[4];

                    //gan gia tri cho phan tu moi
                    newArray[newArray.Length - 1] = new Employee(no, name, email, isManager, password);

                    //bien mang cu thanh mang moi
                    employees = newArray;
                }
                while (reader.ReadLine()!=null);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public override void Export()
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\ADMIN\\.TRAN VAN TRUNG\\data.csv", true, System.Text.Encoding.UTF8);
            try
            {
                foreach (Employee e in employees)
                {
                    streamWriter.WriteLine(e);
                    streamWriter.Flush();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public override int Login()
        {
            Console.Write("Nhap Email:");
            string email = Console.ReadLine();
            Console.Write("Nhap Password:");
            string password = Console.ReadLine();
            int result;
            foreach (Employee emp in employees)
            {
                if (emp.GetMail().Equals(email) & emp.GetPassword().Equals(password))
                {
                    if (emp.GetIsManager().Equals(true))
                    {
                        Console.WriteLine("Dang nhap thanh cong. Ban la Manager");
                        return 1; 
                    }
                    Console.WriteLine("Dang nhap thanh cong. Ban la User");
                    return 2;
                }
            }
            Console.WriteLine("Dang nhap khong thanh cong");
            return 0;
        }
        public override void AddNew()
        {
            //khai bao 1 mang trung gian co so phan tu lon hon mang goc la 1
            Employee[] newArray = new Employee[this.employees.Length + 1];
            
            //copy cac phan tu cua mang cu vao mang moi
            for (int i = 0; i < this.employees.Length; i++)
            {
                newArray[i]= this.employees[i];
            }

            //nhap lieu phan tu moi
            Console.Write("Nhap Number: ");
            String no = Console.ReadLine();
            Console.Write("Nhap Ten: ");            
            String name=Console.ReadLine();
            Console.Write("Nhap Email: ");
            String email=Console.ReadLine();
            Console.Write("La quan ly y/n:");
            Boolean isManager = false;
            if (Console.ReadLine().ToUpper() == "Y") { isManager = true; }
            Console.Write("Nhap Password:");
            String password=Console.ReadLine();

            //gan gia tri cho phan tu moi
            newArray[newArray.Length-1] = new Employee(no, name, email,isManager, password );
            
            //bien mang cu thanh mang moi
            employees = newArray;
        }

        public override void Delete()
        {
            //in tat ca cac ban ghi hien co
            PrintList(employees);
            
            //xac dinh ban ghi muon xoa
            Console.Write("Chon ban ghi muon xoa: ");
            int idRecord=Convert.ToInt32(Console.ReadLine())-1;
            
            //copy de va sua lai kich thuoc mang
            Array.Copy(employees,idRecord+1, employees,idRecord, employees.Length-idRecord-1);
            Array.Resize(ref employees, employees.Length - 1);
        }
        public override void Update()
        {
            //in tat ca cac ban ghi hien co
            PrintList(employees);

            //xac dinh ban ghi muon cap nhat
            Console.Write("Chon ban ghi muon Update: ");
            int idRecord = Convert.ToInt32(Console.ReadLine()) - 1;

            //nhap lieu phan tu Update
            Console.Write("Nhap No : ");
            employees[idRecord].SetNo(Console.ReadLine());
            Console.Write("Nhap Ten: ");
            employees[idRecord].SetName(Console.ReadLine());
            Console.Write("Nhap Email: ");
            employees[idRecord].SetMail(Console.ReadLine());
        }
        public override void Find()
        {
            Console.Write("Enter EmpNo or Name: ");
            String searchKey = Console.ReadLine();

            //search
            Employee[] result = new Employee[MAX];
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey))
                {
                    result[count] = emp;
                    count++;
                }
            }
            //Print
            PrintList(result);
        }
        private void PrintList(Employee[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine("Ban ghi thu: " + (i+1) + " " + arr[i]);
                }
            }
        }
    }
}
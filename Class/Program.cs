namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int selected = 0;
            EmployeeManager manager = new EmployeeManager();
            int loginCode=manager.Login();
            if (loginCode == 1)
            {
                do
                {
                    Console.WriteLine("***EMPLOYEE MANAGER");
                    Console.WriteLine("\t1.Search Employee by Name or EmpNo");
                    Console.WriteLine("\t2.Add New Employee");
                    Console.WriteLine("\t3.Update Employee");
                    Console.WriteLine("\t4.Delete Employee");
                    Console.Write("Select (1-5): ");
                    selected = Convert.ToInt16(Console.ReadLine());


                    switch (selected)
                    {
                        case 1:
                            manager.Find();
                            break;
                        case 2:
                            manager.AddNew();
                            break;
                        case 3:
                            manager.Update();
                            break;
                        case 4:
                            manager.Delete();
                            break;
                        case 5:
                            Console.WriteLine("------------END----------");
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                } while (selected != 5);
                Console.WriteLine("----END----");
                Console.ReadLine();
            }
            if (loginCode == 2)
            {
                Console.WriteLine("***EMPLOYEE SEARCHING***");
                manager.Find();
                Console.WriteLine("----END----");
                Console.ReadLine();
            }
        }
    }
}
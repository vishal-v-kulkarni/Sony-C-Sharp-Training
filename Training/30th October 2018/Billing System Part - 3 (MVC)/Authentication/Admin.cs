using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BillingSystem
{
    public class Admin : Employee
    {

        //public override void empLogin()
        //{

        //    // Authenticate au = new Authenticate();
        ////    Authenticate.getCredentials(this);

        //}
        //public void doSales(int empId)
        //{

        //}
        //public override void logout()
        //{
        //    Environment.Exit(0);

        //}
       
       

        public void ModifyUsers()
        {
            Console.WriteLine("1.AddUser\n2.DeleteUser\n3.ModifyUser");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:

                    //Employee[] empfrom = new Employee[3]{ new Employee("100", "Raju"), new Employee("200", "Govinda"),
                    //                           new Employee("ad1000","ramRam")};
                    Console.WriteLine("Enter UserId");
                    string newId = Console.ReadLine();
                    Console.WriteLine("Enter UserPassword");
                    string newPassword = Console.ReadLine();
                    Employee emp5 =new Employee (newId, newPassword) ;
                    FileStream f = new FileStream(@"D:\Cred.bin", FileMode.Open, FileAccess.Read);
                    long len = f.Length;
                    //Console.WriteLine(len);
                    f.Close();

                    FileStream fs = new FileStream(@"D:\Cred.bin", FileMode.Append, FileAccess.Write);
                    byte[] e2b = Employee.EmpArrayToBytes(emp5);
                    fs.Seek(e2b.Length, SeekOrigin.Current);
                    fs.Write(e2b, 0, e2b.Length);
                    fs.Close();

                    FileStream fs1 = File.OpenRead(@"D:\Cred.bin");

                    byte[] bts5 = Employee.EmpArrayToBytes(emp5);
                    byte[] btsemp5 = new byte[bts5.Length];
                    fs1.Read(btsemp5, 0, btsemp5.Length);

                    Employee empto5 = Employee.BytesToEmpArray(btsemp5);
                    //foreach (Employee emp in empto)
                    //{
                    Console.WriteLine(empto5);
                    // }
                    fs1.Close();

                    break;
                case 2:

                    Console.WriteLine("user deleted");

                    break;
                case 3:

                    Console.WriteLine("user details modified");

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    ModifyUsers();
                    break;

            }


        }
        public void logout()
        {
           // Environment.Exit(0);
        }

        public void doInventory()
        {
            Console.WriteLine("Invoke Inventory class");
        }
        public void generateEmpReport()
        {
            Console.WriteLine("Invoke EmpReport class");
        }
        public void generateSalesReport()
        {
            Console.WriteLine("Invoke PurchaseRange class");
        }
        public void doSales(string empId)
        {

        }


    }
}

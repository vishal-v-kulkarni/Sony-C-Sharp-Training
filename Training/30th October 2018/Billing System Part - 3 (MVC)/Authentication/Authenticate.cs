using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace BillingSystem
{
    public class Authenticate
    {
        public void getCredentials(string id, string pass,Employee[] emp)
        {
            FileStream fs1 = File.OpenRead(@"D:\Cred.bin");
            Employee[] empto = new Employee[4];
            for (int i = 0; i < 4; i++)
            {
                byte[] bts1 = Employee.EmpArrayToBytes(emp[i]);
                byte[] bts = new byte[bts1.Length];
                fs1.Read(bts, 0, bts.Length);
                empto[i] = Employee.BytesToEmpArray(bts);
            }
            fs1.Close();
            foreach (Employee e in empto)
                {
                    if ((e.eId).Equals(id))
                    {
                        Console.WriteLine("CheckingPassword");
                        matchCredentials(e.eId, pass, e.ePassword);

                    }

                    else
                    {


                    }

                }
            
            
           
            
            //fs1.Close();


        }
        public void matchCredentials(string id, string enteredPassword, string savedPassword)
        {

            if (enteredPassword == savedPassword)
            {
                int choice;
                Console.WriteLine("Logged in Successfully as Admin");
                Admin ad = new Admin();
                do
                {
                    Console.WriteLine("1.ModifyUser\n2.DoInventory\n3.GenerateEmpReport\n4.GenerateSalesReport\n5.DoSales\n6.Logout");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ad.ModifyUsers();

                            break;
                        case 2:
                            ad.doInventory();
                            break;
                        case 3:
                            ad.generateEmpReport();
                            break;
                        case 4:
                            ad.generateSalesReport();
                            break;
                        case 5:
                            ad.doSales(id);
                            break;
                        case 6:
                            ad.logout();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                } while (choice < 7);

            }
            //else if (enteredPassword == "shopkeeper")
            //{
            //    Console.WriteLine("Logged in Successfully as Shopkeeper");
            //    Shopkeeper sk1 = new Shopkeeper();
            //    sk1.doSales(id);
            //}
            else
            {
                Console.WriteLine("Invalid Credentials");
            }
        }
    }
}

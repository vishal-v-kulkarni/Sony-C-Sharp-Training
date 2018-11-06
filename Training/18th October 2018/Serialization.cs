using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    [Serializable]
    class Employee
    {
        int empid;
        string name;
        float salary;

        public Employee(int id,string nam,float sal)
        {
            empid = id;
            name = nam;
            salary = sal;
        }

        public override string ToString()
        {
            string str;
            str = "\nEmpid      :   " + empid +
                "\nName     :   " + name +
                "\nSalary       :" + salary;

            return str;

        }

        public static Employee BytesToEmployee(byte[] bytes)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter binform = new BinaryFormatter();
            memst.Write(bytes, 0, bytes.Length);
            memst.Seek(0, SeekOrigin.Begin);
            return binform.Deserialize(memst) as Employee;

        }

        public byte[] ToByteArray()
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter binform = new BinaryFormatter();
            binform.Serialize(memst, this);
            return memst.ToArray();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Serializing employee object to bytes
            Employee e1 = new Employee(12, "Govinda", 90000);
            FileStream fs = File.Create(@"D:\empfile.bin");
            byte[] e2b = e1.ToByteArray();
            fs.Write(e2b, 0, e2b.Length);
            fs.Close();

            //Deserializing bytes to employee object
            FileStream fs1 = File.OpenRead(@"D:\empfile.bin");
            byte[] bts = new byte[fs1.Length];
            fs1.Read(bts, 0, bts.Length);
            Employee e = Employee.BytesToEmployee(bts);
            Console.WriteLine(e);
            fs1.Close();


        }
    }
}

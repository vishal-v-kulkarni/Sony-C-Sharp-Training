using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeMultipleObjects_File
{
    [Serializable]
    class Employee
    {
        int empid;
        string name;

        public Employee(int id, string nam)
        {
            empid = id;
            name = nam;
        }

        public override string ToString()
        {
            string str;
            str = "\nEmpid      :   " + empid +
                "\nName     :   " + name;

            return str;

        }

        public static Employee[] BytesToEmployee(byte[] bytes)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter binform = new BinaryFormatter();
            memst.Seek(0, SeekOrigin.Begin);
            memst.Write(bytes, 0, bytes.Length);
            memst.Seek(0, SeekOrigin.Begin);
            return binform.Deserialize(memst) as Employee[];

        }

        public static byte[] ToByteArray(Employee[] empfrom)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter binform = new BinaryFormatter();
            binform.Serialize(memst, empfrom);
            return memst.ToArray();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Serializing employee object to bytes
            Employee[] empfrom = new Employee[3]{ new Employee(100, "Raju"), new Employee(200, "Govinda"),
                                               new Employee(300,"ramRam")};
            FileStream fs = File.Create(@"D:\empfile.bin");
            byte[] e2b = Employee.ToByteArray(empfrom);
            fs.Write(e2b, 0, e2b.Length);
            fs.Close();

            //Deserializing bytes to employee object
            FileStream fs1 = File.OpenRead(@"D:\empfile.bin");
            byte[] bts = new byte[fs1.Length];
            fs1.Read(bts, 0, bts.Length);
            Employee[] empto = Employee.BytesToEmployee(bts);
            Console.WriteLine(empto[0]);
            Console.WriteLine(empto[1]);
            Console.WriteLine(empto[2]);
            fs1.Close();


        }
    }
}

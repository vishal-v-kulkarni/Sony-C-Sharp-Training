using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeMultipleObjects
{
    [Serializable]
    class Employee
    {
        public int eid;
        public string ename;
        public Employee()
        { }
        public Employee(int id, string name)
        {
            eid = id; ename = name;
        }
        public override string ToString()
        {
            return "Eid : " + eid + "  Name : " + ename + "\n";
        }

        public static byte[] EmpArrayToBytes(Employee[] empfrom)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(memst, empfrom);
            return memst.ToArray();
        }
        public static Employee[] BytesToEmpArray(byte[] ebytes)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            memst.Seek(0, SeekOrigin.Begin);
            memst.Write(ebytes, 0, ebytes.Length);
            memst.Seek(0, SeekOrigin.Begin);
            return bf.Deserialize(memst) as Employee[];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] empfrom = new Employee[3]{ new Employee(100, "Raju"), new Employee(200, "Govinda"),
                                               new Employee(300,"ramRam")};

          
            // Serialize array of objects
            byte[] bytes = Employee.EmpArrayToBytes(empfrom);

            //Deserialize array of objects
            Employee[] empto = Employee.BytesToEmpArray(bytes);

            Console.WriteLine("---After Deserialize----");
            Console.WriteLine(empto[0]);
            Console.WriteLine(empto[1]);
            Console.WriteLine(empto[2]);

        }
    }
}

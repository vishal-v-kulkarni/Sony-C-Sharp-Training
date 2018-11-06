using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;

namespace BillingSystem
{
    [Serializable]
    public class Employee
    {
        public string eName;
        public string eId;
        public string eEmail;
        public string ePassword;
        public long ePhone;
        public int eSalesMatrix;

        public Employee()
        {

        }
        public Employee(string id, string pass)
        {
            eId = id; ePassword = pass;
        }
        public override string ToString()
        {
            string str;
            str = "\nEmpId:" + eId +
                "\nPassword:" + ePassword;

            return str;
        }

        public static Employee BytesToEmpArray(byte[] ebytes)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            memst.Seek(0, SeekOrigin.Begin);
            memst.Write(ebytes, 0, ebytes.Length);
            memst.Seek(0, SeekOrigin.Begin);
            return bf.Deserialize(memst) as Employee;
        
        }


        public static byte[] EmpArrayToBytes(Employee empfrom)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(memst, empfrom);
            return memst.ToArray();
        }

       
    }
}

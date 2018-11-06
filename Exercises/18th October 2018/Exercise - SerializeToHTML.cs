using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Diagnostics;

namespace Serialization
{
    [Serializable]
    class Product
    {

        public int proid;
        public string proname;
        public double proprice;
        public int proqty;
        public int progst;


        public Product(int id,string name,double price,int qty,int gst)
        {
            proid = id;
            proname = name;
            proprice = price;
            proqty = qty;
            progst = gst;

        }

        
        public static Product BytesToEmployee(byte[] bytes)
        {
            MemoryStream memst = new MemoryStream();
            BinaryFormatter binform = new BinaryFormatter();
            memst.Write(bytes, 0, bytes.Length);
            memst.Seek(0, SeekOrigin.Begin);
            return binform.Deserialize(memst) as Product;

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
            int iNum=0;
            int id,qty,gst;
            string name;
            double price;

            Console.Write("Enter the number of products : ");
            iNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Product[] pro = new Product[iNum];
            StreamWriter F = new StreamWriter(@"D:\serialize.html",false,Encoding.ASCII);

            F.WriteLine("<html>");
            F.WriteLine("<head>");
            F.WriteLine("<style>"+
                        "table, th, td {"+
                        "border: 1px solid black;"+
                        "}</style> ");

            F.WriteLine("</head>");
            F.WriteLine("<body>");
            F.WriteLine("<table style='width: 100 % '>" +
                "<tr>" +
                "<th>Product ID</th>" +
                "<th>Name</th>" +
                "<th>Price</th>" +
                "<th>Quantity</th>" +
                "<th>GST</th>" +
                "</tr>");

            for (int iCounter = 0; iCounter < iNum; iCounter++)
            {
                //Reading the product details
                Console.Write("Enter the Product {0} ID : ", iCounter + 1);
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the Product {0} Name : ", iCounter + 1);
                name = Console.ReadLine();
                Console.Write("\nEnter the Product {0} Price : ", iCounter + 1);
                price = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter the Product {0} Quantity : ", iCounter + 1);
                qty = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the Product {0} GST : ", iCounter + 1);
                gst = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                pro[iCounter] = new Product(id,name,price,qty,gst);

                //Serializing the product details to bytes
                FileStream fs = File.Create(@"D:\serialize.bin");
                byte[] e2b = pro[iCounter].ToByteArray();
                fs.Write(e2b, 0, e2b.Length);
                fs.Close();

                //Deserializing the product details to Product object
                FileStream fs1 = File.OpenRead(@"D:\serialize.bin");
                byte[] bts = new byte[fs1.Length];
                fs1.Read(bts, 0, bts.Length);
                Product p = Product.BytesToEmployee(bts);

                //Writing the product details to the HTML File
                F.WriteLine("<tr>" +
                    "<td>" + p.proid + "</td>" +
                    "<td>" + p.proname + "</td>" +
                    "<td>" + p.proprice + "</td>" +
                    "<td>" + p.proqty + "</td>" +
                    "<td>" + p.progst + "</td>" +
                "</tr>");

                fs1.Close();

            }
            F.WriteLine("</table>");
            F.WriteLine("</body>");
            F.WriteLine("</html>");
            F.Close();

            Process.Start(F);

        }
    }
}

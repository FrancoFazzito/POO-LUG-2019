using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SERIALIZACION
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(10000, "juan");
            BinaryFormatter formatter = new BinaryFormatter();
            //directorio //crear         //aceso por que escribimos //exclusividad
            Stream stream = new FileStream("auto2.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, auto);
            stream.Close();

            Console.WriteLine("------");

            Stream stream2 = new FileStream("auto2.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            stream2.Close();

            Console.WriteLine("deseralizacion");
            auto.muestra();

            Auto auto2 = new Auto(10000, "juan");
            SoapFormatter SOAP = new SoapFormatter();

            Stream stream3 = new FileStream("auto.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            SOAP.Serialize(stream3 , auto2);
            stream3.Close();

            Console.WriteLine("------");

            Stream stream4 = new FileStream("auto.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            stream4.Close();

            Console.WriteLine("deseralizacion");
            auto.muestra();
            Console.ReadKey();

        }
    }
}

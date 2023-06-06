using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Havid", 21);
            person1.InfoPerson();

            Console.WriteLine("================================");

            Karyawan karyawan1 = new Karyawan("22019112", "Karyawan", "Havid", 21);
            karyawan1.InfoKaryawan("220500033", "Karyawan");
            karyawan1.InfoPerson();
           

            Console.ReadKey();
        }

    }
}
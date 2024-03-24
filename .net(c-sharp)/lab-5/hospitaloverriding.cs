using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_p_4
{
    class Program5
    {
        public static void Main(string[] args)
        {
            Hospital hos = new Hospital();
            Apollo ap = new Apollo();
            Wockhardt wh = new Wockhardt();
            Gokul_Superspeciality gs = new Gokul_Superspeciality();

            hos.hospitaldetails();
            ap.hospitaldetails();
            wh.hospitaldetails();
            gs.hospitaldetails();



        }
    }

    class Hospital
    {
        public virtual void hospitaldetails()
        {
            Console.WriteLine("Hospital");
        }
    }
    class Apollo : Hospital
    {
        override public void hospitaldetails()

        {
            Console.WriteLine("Apollo");
        }
    }
    class Wockhardt : Hospital
    {
        override public void hospitaldetails()
        {
            Console.WriteLine("Wockhardt");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        override public void hospitaldetails()
        {
            Console.WriteLine("Gokul_Superspeciality");
        }
    }

}
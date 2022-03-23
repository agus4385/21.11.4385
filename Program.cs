using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tugas_ClassObject_Agus_Kurniawan
{
    class Program
    {

        public static void Main(string[] args)
        {
            //Membuat Objek Taxi 
            Taxi taxi = new Taxi();

            //Pengesahan Nilai
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //Pemanggilan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }  
    }
}




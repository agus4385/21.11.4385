using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_ClassObject_Agus_Kurniawan
{
    class Taxi
    {
        
        //Propeti
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        private string OnDutybs()
        {
            return OnDuty ? "Benar" : "Salah";
        }
        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On DutyBS   : {0}", OnDutybs());
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0}\nSedang Mengantar Penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0}\nSelesai Mengantar Penumpang", DriverName);
        }
    }
}
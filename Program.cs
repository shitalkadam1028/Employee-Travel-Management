using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassModel_ClassLibrary;

namespace ConsoleApp_Travel_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TravelManage travelManage = new TravelManage();

           Menu.ShowMenu();
         //  travelManage.ViewTravelRequest();

            Console.ReadLine();
        }
    }
}

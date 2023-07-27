using System;
using AMS_OOP_Heranca;
namespace AMS_OOP_Heranca
{
    class Plane : Vehicle
    {
        private int capacitySeat;
        private double km;

        public Plane(String id, String description,int capacitySeat, double km): base(id, description)
        {
            this.capacitySeat = capacitySeat;
            this.km = km;
        }

        public int PgetCap()
        {
            return capacitySeat;
        }
        public double Pgetkm()
        {
            return km;
        }
        public void Pilot()
        {
             Console.WriteLine("The Plane is beeing Piloted");
        }


    }
}
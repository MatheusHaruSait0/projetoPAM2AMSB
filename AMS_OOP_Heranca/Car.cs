using System;
using AMS_OOP_Heranca;
namespace AMS_OOP_Heranca
{
    class Car : Vehicle
    
    {

        private int capacitySeat;
        private double km;

        public Car(String id, String description, int capacitySeat, double km): base(id, description)
        {
            this.capacitySeat = capacitySeat;
            this.km = km;
        }

        public int CgetCap()
        {
            return capacitySeat;
        }
        public double CgetKm()
        {
            return km;
        }
        public void drive()
        {
            Console.WriteLine("O Carro esta sendo dirigido");
        }


    }
}
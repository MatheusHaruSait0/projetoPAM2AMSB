using AMS_OOP_Heranca;

Plane a1 = new Plane("A032A2","Airline", 100, 8000);
Car c1 = new Car("BO2A52","Fusca", 5, 24);

Console.WriteLine("Plane: \n" + "Airplane id: " + a1.getId()+ "\nAirplane Description: "+ a1.getDes() + "\nAirplane Capacity Seat: "+ a1.PgetCap()+ "\nAirplane km: "+ a1.Pgetkm());
Console.WriteLine(a1.Pilot());
Console.WriteLine("=============================");
Console.WriteLine("=============================");
Console.WriteLine("Car: \n"+"Car id: " + c1.getId()+ "\nCar Description: "+ c1.getDes() + "\nCar Capacity Seat: "+ c1.CgetCap()+"\nCar km: "+ c1.CgetKm());
Console.WriteLine(c1.drive());

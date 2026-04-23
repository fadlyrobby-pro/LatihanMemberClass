using System;

class Program
{
    static void Main(string[] args)
    {
        // membuat objek tiket1
        PlaneTicket tiket1 = new PlaneTicket();
        tiket1.Origin = "YOGYAKARTA";
        tiket1.Destination = "JAKARTA";
        tiket1.Cost = 100;
        tiket1.Currency = "USD";

        // membuat objek tiket2
        PlaneTicket tiket2 = new PlaneTicket();
        tiket2.Origin = "JAKARTA";
        tiket2.Destination = "SINGAPORE";
        tiket2.Cost = 1500000;
        tiket2.Currency = "IDR";

        // menampilkan output
        Console.WriteLine("Latihan Member Class");
        Console.WriteLine("------------------------------");
        tiket1.PrintSummary();
        tiket2.PrintSummary();

        Console.ReadKey();
    }
}
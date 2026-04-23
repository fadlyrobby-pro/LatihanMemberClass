using System;

public class PlaneTicket
{
    // field (variabel privat sebagai penampung data)
    private string _origin;
    private string _destination;
    private float _cost;
    private string _currency;

    // properties versi panjang (menggunakan get dan set accessor)
    public string Origin
    {
        get { return _origin; }
        set { _origin = value; }
    }

    public string Destination
    {
        get { return _destination; }
        set { _destination = value; }
    }

    public float Cost
    {
        get { return _cost; }
        set { _cost = value; }
    }

    public string Currency
    {
        get { return _currency; }
        set { _currency = value; }
    }

    // method untuk mencetak ringkasan tiket
    public void PrintSummary()
    {
        Console.WriteLine("Origin: {0}", Origin);
        Console.WriteLine("Destination: {0}", Destination);

        // Cek jika mata uang USD, konversi ke Rupiah (asumsi 1 dolar = 15.000)
        if (Currency == "USD")
        {
            float costIDR = Cost * 15000;
            Console.WriteLine("Cost: {0} ({1} {2})", Cost, costIDR, "IDR");
        }
        else
        {
            Console.WriteLine("Cost: {0}", Cost);
        }

        Console.WriteLine("------------------------------");
    }
}
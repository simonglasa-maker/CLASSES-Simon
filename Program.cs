namespace Cvicenie_clasess_13_2_a___d;

class Program
{
    static void Main(string[] args)
    {
     Ucet ucet1 = new Ucet();
     ucet1.Cislo = "1234";
     ucet1.Zostatok = 100;
     ucet1.Majitel = "Jozko";
     
     Ucet ucet2 = new Ucet();
     ucet2.Cislo = "4321";
     ucet2.Zostatok = 250;
     ucet2.Majitel = "Sedliak_Matej";

     Console.WriteLine(ucet1.Majitel + " zostatok je: "+ucet1.Zostatok );

     ucet1.VlozPeniaze(20);
     Console.WriteLine(ucet1.Majitel + " zostatok po vlozeni sumy je: "+ucet1.Zostatok );
     ucet1.VyberPeniaze(75);
     Console.WriteLine(ucet1.Majitel + " zostatok po Výbere sumy je: "+ucet1.Zostatok );
     
     
     Console.WriteLine(ucet2.Majitel + " zostatok je: "+ucet2.Zostatok );

     ucet1.VlozPeniaze(200);
     Console.WriteLine(ucet2.Majitel + " zostatok po vlozeni sumy je: "+ucet2.Zostatok );
     ucet2.VyberPeniaze(15);
     Console.WriteLine(ucet2.Majitel + " zostatok po Výbere sumy je: "+ucet2.Zostatok );



    }
}
class Ucet
{
    public string Cislo = "";
    public decimal Zostatok = 0;
    public string Majitel = "";
    
    public decimal VlozPeniaze(decimal suma)
    {
        if (suma <= 0)
        {
            Console.WriteLine("Zadali ste chybne udaje");
            return Zostatok;
        }
        Zostatok += suma ;
        return Zostatok;
        
    }

    public bool VyberPeniaze(decimal suma)
    {
        if ( suma <= 0 )
        {
            Console.WriteLine("Zadali ste chybne udaje");
            return false;
        }

        if (Zostatok > suma)
        {
            Zostatok -= suma;
            return true;
        }
        else
        {
            Console.WriteLine("Malo penazi na vybratie z uctu");
            return false;
        }
    }
}

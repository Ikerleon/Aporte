class Program
{


    public static void Main(String[] args)
    {

        //telefono #1
        Console.WriteLine("------------------------------------------");
        var telefono = new producto1();
        Console.WriteLine(telefono.Reparacion());

        var reparacion = new PantallaRota(telefono);
        Console.WriteLine(reparacion.Reparacion());

        var reparacion2 = new Sistemaoperativo(telefono);
        Console.WriteLine(reparacion2.Reparacion());

        var reparacion3 = new Formateo(telefono);
        Console.WriteLine(reparacion3.Reparacion());

        Console.WriteLine(telefono.Hardware());

        var cargador = new Cargador(telefono);
        Console.WriteLine(cargador.Hardware());
        Console.WriteLine("------------------------------------------");




        //telefono 2
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        var telefono2 = new producto2();
        Console.WriteLine(telefono2.Reparacion());

        var reparacion4 = new Sistemaoperativo(telefono2);
        Console.WriteLine(reparacion4.Reparacion());

        var reparacion5 = new Formateo(telefono2);
        Console.WriteLine(reparacion5.Reparacion());

        var reparacion6 = new PantallaRota(telefono);
        Console.WriteLine(reparacion6.Reparacion());

        Console.WriteLine(telefono2.Hardware());

        var parlante2 = new Parlante(telefono2);
        Console.WriteLine(parlante2.Hardware());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");


        //telefono 3
        var telefono3 = new producto3();
        Console.WriteLine(telefono3.Reparacion());

        var reparacion7 = new Sistemaoperativo(telefono3);
        Console.WriteLine(reparacion7.Reparacion());

        var reparacion8 = new Formateo(telefono3);
        Console.WriteLine(reparacion8.Reparacion());

        var reparacion9 = new PantallaRota(telefono3);
        Console.WriteLine(reparacion9.Reparacion());

        Console.WriteLine(telefono3.Hardware());

        var audifonos3 = new Audifonos(telefono3);
        Console.WriteLine(audifonos3.Hardware());
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------");
    }
}
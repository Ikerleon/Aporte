using System;
public class Decorador:OrdenBase 
{
    protected OrdenBase orden;

    public Decorador(OrdenBase orden)
    {
        this.orden= orden;
    }
    public override string Hardware(){
      return orden.Hardware();
    }
    public override string Reparacion(){
      return orden.Reparacion();
    }
}
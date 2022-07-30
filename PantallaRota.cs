public class PantallaRota: Decorador{

    public PantallaRota(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string Reparacion(){
        var repacion = "El arreglo de tu pantalla se ha completado con exito";
          return repacion;
    }
}
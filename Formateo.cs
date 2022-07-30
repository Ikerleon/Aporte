public class Formateo: Decorador{

    public Formateo(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string Reparacion(){
        var repacion = "El formateo se ha completado con exito";
          return repacion;
    }
}
public class Sistemaoperativo: Decorador{

    public Sistemaoperativo(OrdenBase ordenBase):base(ordenBase){ }
    public virtual string Reparacion(){
        var repacion = "La reparacion de tu telefono que tenia mal el sistema operativo esta lista";
          return repacion;
    }
}
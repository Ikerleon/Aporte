public class Parlante: Decorador{

    public Parlante(OrdenBase ordenBase):base(ordenBase){ }

    public override string Hardware(){
        var teclado = "Has agregado el parlante adicional";
      return teclado;
    }
}
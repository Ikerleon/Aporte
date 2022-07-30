public class Audifonos: Decorador{
    
    public Audifonos(OrdenBase ordenBase):base(ordenBase){
        
    }
    public override string Hardware(){
        var teclado = "Has agregado el audifono adicional";
        return teclado;
    }
}
using parcial.Entidades;

namespace parcial.negocio
{
    public class ClsVenta

    {
        public int multi (Venta venta){
            return venta.Resultado = venta.PrecioDelProducto * venta.CantidadDeProducto;
        }
        public int multiplicacion(Venta venta){
            venta.Resultado = venta.PrecioDelProducto * venta.CantidadDeProducto; 
            if (venta.Resultado >= 50){
                venta.resultadoDos = venta.Resultado - 10;
                return venta.resultadoDos;
            }return venta.Resultado;
        }
    }
}
using parcial.Entidades;
namespace parcial.negocio
{
    public class ClsPasss
    {
        public bool Autentiacacion (Passs passs)
        {
       
        if (passs.passs.Equals("TUNOMBRE") && passs.password.Equals("123"))
        {
            return true;
        }
        return false;
        }
    }
}
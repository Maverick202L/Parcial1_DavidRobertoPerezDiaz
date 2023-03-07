
using parcial.Entidades;
using parcial.negocio;

Passs passs = new Passs();
ClsPasss clsPasss = new ClsPasss();

Venta venta = new Venta();
ClsVenta clsVenta = new ClsVenta();

Console.WriteLine("ingresa tu usuario");  
passs.passs = Console.ReadLine ();
Console.WriteLine("Ingrese su contraseña");
passs.password = Console.ReadLine();

bool resultado = clsPasss.Autentiacacion(passs); 

if(resultado==true){Console.WriteLine("INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA");
    Console.WriteLine("ingresa el identificador del producto");  
    venta.IdentificadorDeProducto = Console.ReadLine ();
    Console.WriteLine("Ingresa el nombre del producto");
    venta.NombreDelProducto = Console.ReadLine();
    Console.WriteLine("ingresa la descripccion del producto");  
    venta.DescripccionDelProducto = Console.ReadLine ();
    Console.WriteLine("Ingresa el precio del poducto");
    venta.PrecioDelProducto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingresa la cantidad del producto");
    venta.CantidadDeProducto = Convert.ToInt32(Console.ReadLine());    
    }    
else {Console.WriteLine("NOMBRE DE USUARIO INCORRECTO");}

Console.WriteLine("*********************************");
Console.WriteLine("el identificador del producto es");
Console.WriteLine(venta.IdentificadorDeProducto);
Console.WriteLine("*********************************");
Console.WriteLine("nombre del producto");
Console.WriteLine(venta.NombreDelProducto);
Console.WriteLine("*********************************");
Console.WriteLine("Descripccion del producto");
Console.WriteLine(venta.DescripccionDelProducto);
Console.WriteLine("*********************************");
Console.WriteLine("precio del producto");
Console.WriteLine(venta.PrecioDelProducto);
Console.WriteLine("*********************************");
Console.WriteLine("cantidad de productos");
Console.WriteLine(venta.CantidadDeProducto);
Console.WriteLine("*********************************");

Console.WriteLine($"por la cantidad de {venta.CantidadDeProducto} {venta.NombreDelProducto}");
Console.WriteLine(clsVenta.multi(venta));

if(venta.Resultado>=50){
    Console.WriteLine("Aplica descuento de $10 dolares");
    Console.WriteLine($"su total a pagares");
    Console.WriteLine(clsVenta.multiplicacion(venta));

    }
else{
    Console.WriteLine("No Aplica descuento");
}



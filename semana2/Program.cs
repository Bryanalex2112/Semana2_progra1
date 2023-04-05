
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//***************************************************
using semana2.entidades;
using semana2.Negocio;

Operaciones operacione = new Operaciones();
ClsOperaciones clsOperaciones = new ClsOperaciones();

Console.WriteLine("ingresa el primer dato");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
Console.WriteLine("Ingrese el segundo dato");
operacione.dato2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("el esultado de la opeacion es");
Console.WriteLine(clsOperaciones.Suma(operacione));
//*************************************************

/*
//************************************************
//NOTA
Nota nota = new Nota();
ClsNota clsNota = new ClsNota ();

Console.WriteLine("ingresa tu nota");
string variableNota = Console.ReadLine();
int converNota = Convert.ToInt32(variableNota);
nota.nota = converNota;
string resultadoNota = clsNota.Res(nota);
Console.WriteLine(resultadoNota);
//****************************************
*/
/*
//***************************************
//USER
User user = new User();
ClsUser clsUser = new ClsUser();

Console.WriteLine("ingresa tu usuario");  
user.user = Console.ReadLine ();
Console.WriteLine("Ingrese su contraseña");
user.password = Console.ReadLine();

bool Resultado = clsUser.Autentiacacion(user); 
if(Resultado==true){
    Console.WriteLine("Muy Bien");
}else {
    Console.WriteLine("you are bad");
}
//***************************************
*/



using semana2.entidades;

namespace semana2.Negocio
{
    public class ClsOperaciones
    {    
        public int Suma(Operaciones operaciones){
            return operaciones.resultado = operaciones.Dato1 + operaciones.dato2; 
        }
    }
}
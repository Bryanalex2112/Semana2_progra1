using semana2.entidades;

namespace semana2.Negocio
{
    public class ClsUser
    {
        //tipo de dato es utilizado para true and falce = verdadero o falso
        public bool Autentiacacion (User user)
        {
        //if (condicion)
        //Si la condicion de usuario y contraseña se cumplen entrara en el
        //Utilizando compuerta logica AND
        if (user.user.Equals("Brayan") && user.password.Equals("3001"))
        {
            return true;
        }
        
        return false;
       
        }
    }
} 
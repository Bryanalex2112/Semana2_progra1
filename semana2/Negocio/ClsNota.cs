using semana2.entidades;
namespace semana2.Negocio

{
    public class ClsNota
    {
        public string Res(Nota nota){
            if (nota.nota >=5 ){
                return "Usted Paso El año";
            }else return "usted aplaso el año";
        }
    
    }
}
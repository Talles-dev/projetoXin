using System.Collections.Generic;

namespace Projeto1.Interfaces // so vai utilizar essa interface quem especificar
{
    public interface Irepositorio<T>
    { //T é tipo generico
         List<T> Lista(); //metodo
         
         T RetornoPorId(int Id);// T = Id  
         
         void Insere(T entidade);
         
         void Exclui (int Id);

         void Atualiza(int Id, T entidade);

         int ProximoId(); 
    }
}
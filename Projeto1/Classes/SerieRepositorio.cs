using System;
using System.Collections.Generic;
using Projeto1.Interfaces; // especifiquei o uso da interface

namespace Projeto1
{
    public class SerieRepositorio : Irepositorio<Serie>
    {//implementa a inteface do Irepositorio da classe Serie - subst. T por serie
        
        private List<Serie> listaSerie = new List<Serie>();

        public List<Serie> Lista()
        {
            return listaSerie;
        }  

        public void Atualiza(int Id, Serie entidade)
        {// objeto listaserie recebe a serie como entidade e bota na posicao Id
            listaSerie[Id] = entidade;
        }
        
        public void Insere(Serie entidade)
        { // adiciona entidade a lista de serie
            listaSerie.Add(entidade);
        }

        public void Exclui (int Id)        
        { //metodo boleano de declarar excluidp
            listaSerie[Id].Excluir();
        }
        
        public int ProximoId()
        {//garante que uma entidade nao sobrescreva a outra
            return listaSerie.Count;
        }

        public Serie RetornoPorId(int Id)
        {//procura a entidade de acordo com o cod indentificador
            return listaSerie[Id];
        }
    }
}
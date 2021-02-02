using System;

namespace Construtores.classes
{
    public class Pessoa
    {
        private string sobrenome;

        public string Sobrenome{
            get {return sobrenome;}
            set {sobrenome = value;}
        }

        private string nome;

        public string Nome{
           get {return nome;}
            set {nome = value;}
        }

        public Pessoa(){

        }
        
        public Pessoa(string firstname, string lastname){
            sobrenome = lastname;
            nome = firstname;
        }

        public Pessoa(string firstname){
            nome = firstname;
        }

        public void Calcular(int n1, int n2){
            Console.WriteLine(n1 + n2);
        }






    }
}
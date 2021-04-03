using System;

namespace Api.Data.Collections
{
    public class Livro
    {
        public string Autor {get;set;}
        public string Titulo {get; set;}
        public string Sinopse {get; set;}
        public string Genero {get; set;}

        public Livro(string autor,  string titulo, string sinopse, string genero)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.Sinopse = sinopse;
            this.Genero = genero;
        }
               
    }
}
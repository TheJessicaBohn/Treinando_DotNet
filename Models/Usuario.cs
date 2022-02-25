using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Treinando_DotNet.Models
{
    public class Usuario
    {
        public long Id { get; set;}
        public string Nome { get; set;}
        public ICollection<Caracteristicas> Caracteristicas { get; set;}

        public Usuario(string nome) 
        {
            this.Nome = nome;  
            Caracteristicas = new List<Caracteristicas>();   
        }

    }
}
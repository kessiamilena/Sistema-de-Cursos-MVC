using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Cursos_POO
{
    public class Tecnico : Curso
    {
        public Tecnico(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor)
        {
        }

        // Sobrescreve o método CalcularPreco
        public override double CalcularPreco()
        {
            return Horas * 20; // valor por hora
        }
    }
}
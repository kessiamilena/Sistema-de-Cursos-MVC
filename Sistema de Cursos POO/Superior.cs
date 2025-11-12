using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_Cursos_POO
{
    public class Superior : Curso
    {
        public Superior(string NomeConstrutor, int HorasConstrutor) : base(NomeConstrutor, HorasConstrutor)
        {
        }

        public override double CalcularPreco()
        {
            return Horas * 40; // valor por hora
        }
    }
}
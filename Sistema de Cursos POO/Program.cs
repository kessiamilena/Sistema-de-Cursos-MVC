namespace Sistema_de_Cursos_POO;

class Program
{
    static void Main(string[] args)
    {
        List<Curso> Cursos = new List<Curso>
            {
                new Tecnico("Desenvolvimento de Sistemas", 360),
                new Superior("Cybersegurança", 500)
            };

            foreach (var curso in Cursos)
            {
                curso.ExibirResumo();
            }
    }
}

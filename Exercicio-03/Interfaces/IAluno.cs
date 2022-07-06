using Exercicio_03.Classes;

namespace Exercicio_03.Interfaces;

public interface IAluno
{
    string Nome { get; set; }
    int NumeroChamada { get; set; }
    List<IDisciplina> ListaDeMaterias { get; set; }
    
}
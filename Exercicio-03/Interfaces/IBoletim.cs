using Exercicio_03.Interfaces;

namespace Exercicio_03.Classes;

public interface IBoletim
{
    public IDisciplina Disciplina { get; set; }
    public double Media { get; set; }
    public float[] Notas { get; set; }



     void GeraBoletim(IDisciplina param1, float[] notas);


}
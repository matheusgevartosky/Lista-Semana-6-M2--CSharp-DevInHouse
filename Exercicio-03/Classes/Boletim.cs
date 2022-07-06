namespace Exercicio_03.Classes;

public class Boletim : IBoletim
{
    public IDisciplina Disciplina { get; set; }
    public double Media { get; set; }
    public float[] Notas { get; set; }
    
    public void GeraBoletim(IDisciplina param1, float[] notas)
    {
        Disciplina = param1;
        Notas = notas;
        Media = notas.Average();
    }

}
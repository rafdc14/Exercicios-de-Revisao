namespace Fundamentos;

public class Exercicios
{
    public void ExecutarExercicios()
    {
        this.ExibirCabecalho();
        AlunoExercicioRevisao alunoExercicioRevisao = new AlunoExercicioRevisao();
        alunoExercicioRevisao.ExecutarExercicioRevisao();
        Console.WriteLine();
        

    }
    private void ExibirCabecalho()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   Exercicios de Revisão");
        Console.WriteLine("======================================");
        Console.WriteLine();

    }
}
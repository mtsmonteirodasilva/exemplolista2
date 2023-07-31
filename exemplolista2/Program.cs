Aluno aluno1 = new Aluno();
aluno1.Nome = "Elias";
aluno1.Cpf = "982-383-930-65";
aluno1.Matricula = 10;

Aluno aluno2 = new Aluno(11, "Matheus", "065-021-762-40", new DateOnly(2006, 11, 17));

List<Aluno> alunos = new List<Aluno>();
{
    alunos.Add(aluno1);
    alunos.Add(aluno2);
}

foreach(Aluno a in alunos)
{
    aluno1.Nome = "José";
    Console.WriteLine($"O nome é: {a.Nome} o cpf é: {a.Cpf} e sua matricula é{a.Matricula}");
}
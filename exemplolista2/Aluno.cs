﻿public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateOnly DataNascimento { get; set; }

    public Aluno()//SOBRECARGA
    {

    }

    public Aluno(int matricula, string nome, string cpf, DateOnly dataNascimento)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.Cpf = cpf;
        this.DataNascimento = dataNascimento;
    }   
}
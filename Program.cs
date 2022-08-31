using System;

namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indicealuno = 0;
            string opcaoUsuario = ObterOpcaoUser();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o Nome do Aluno");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();


                        Console.WriteLine("Informe a Nota do Aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O Valor não é Válido!");
                        }

                        alunos[indicealuno] = aluno;
                        indicealuno++;

                        break;
                    case "2":
                        foreach (var item in alunos)
                        {
                            if(!string.IsNullOrEmpty(item.Nome)){
                                Console.WriteLine($"Aluno: {item.Nome} | Nota: {item.Nota}"); 
                            }
                        }
                        break;
                    case "3":
                        decimal notatotal = 0;
                        int nralunos = 0;

                        for(int i =0; i< alunos.Length;i++ ){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                                notatotal += alunos[i].Nota;
                                nralunos++;
                            }
                        }
                            var mediaGeral = notatotal / nralunos;
                            Conceito conceitoGeral;

                            if(mediaGeral < 3){
                                conceitoGeral = Conceito.D;
                            }else if(mediaGeral > 3 && mediaGeral  < 6){
                                conceitoGeral = Conceito.C;
                            }else if(mediaGeral > 6 && mediaGeral  < 8){
                                conceitoGeral = Conceito.B;
                            }else{
                                conceitoGeral = Conceito.A;
                            }

                            Console.WriteLine($"Média Geral de: {mediaGeral} Conceito Geral: {conceitoGeral}"); 
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUser();

            }

            static string ObterOpcaoUser()
            {
                Console.WriteLine("##############################");
                Console.WriteLine("# Informe a Opção desejada : #");
                Console.WriteLine("##############################");
                Console.WriteLine();
                Console.WriteLine("1- Novo Aluno");
                Console.WriteLine("2- Listar Alunos");
                Console.WriteLine("3- Calcular Média Geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
        }
    }
}
string opcaoUsuario = ObterOpcaoUser();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            //TODO Adicionar Alunos
            break;
        case "2":
            //TODO Listar Alunos
            break;
        case "3":
            //TODO IMprime a Media Geral
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

   opcaoUsuario = ObterOpcaoUser();

}

static string ObterOpcaoUser()
{
    Console.WriteLine("Informe a Opção desejada :");
    Console.WriteLine();
    Console.WriteLine("1- Novo Aluno");
    Console.WriteLine("2- Listar Alunos");
    Console.WriteLine("3- Calcular Média Geral");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine();
    return opcaoUsuario;
}
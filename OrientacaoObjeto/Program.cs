string telefone, celular, email;

Pessoa pessoa = new Pessoa(); //criar objeto
Pessoa pessoa2 = new Pessoa();
Pessoa pessoa3 = new Pessoa();
Pessoa CriarPessoa()//função pessoa
{
    Pessoa p1 = new Pessoa();

    p1.Nome = p1.definirNome(); //Sem parâmetros com retorno
    p1.Sobrenome = p1.definirSobrenome(); // Sem parâmetros com retorno
    p1.Idade = p1.definirIdade(); //Sem parâmetros com retorno
    Console.WriteLine("Informe o telefone: "); //Com parêmetros usando "this"
    telefone = Console.ReadLine();
    p1.definirTelefone(telefone);
    Console.WriteLine("Informe o celular: "); //Com parêmetros usando "this"
    celular = Console.ReadLine();
    p1.definirCelular(celular);
    Console.WriteLine("Informe o email: ");//Com parêmetros usando "this"
    email = Console.ReadLine();
    p1.definirEmail(email);

    return p1;
}

pessoa = CriarPessoa();
pessoa2 = CriarPessoa();
pessoa3 = CriarPessoa();

Console.WriteLine();
Console.WriteLine("*** Pessoa 1 ***");
pessoa.MostrarDados();
Console.WriteLine();
Console.WriteLine("*** Pessoa 2 ***");
pessoa2.MostrarDados();
Console.WriteLine();
Console.WriteLine("*** Pessoa 3 ***");
pessoa3.MostrarDados();


/*
#region p1
Console.WriteLine("*** Pessoa 1 ***");
pessoa.Nome = pessoa.definirNome(); //Sem parâmetros com retorno
pessoa.Sobrenome = pessoa.definirSobrenome(); // Sem parâmetros com retorno
pessoa.Idade = pessoa.definirIdade(); //Sem parâmetros com retorno
Console.WriteLine("Informe o telefone: "); //Com parêmetros usando "this"
telefone = Console.ReadLine();
pessoa.definirTelefone(telefone);
Console.WriteLine("Informe o celular: "); //Com parêmetros usando "this"
celular = Console.ReadLine();
pessoa.definirCelular(celular);
Console.WriteLine("Informe o email: ");//Com parêmetros usando "this"
email = Console.ReadLine();
pessoa.definirEmail(email);
//pessoa.MostrarDados(); //função criada na classe Pessoa para imprimir os dados
#endregion

#region p2
Console.WriteLine("*** Pessoa 2 ***");

pessoa2.Nome = pessoa2.definirNome(); 
pessoa2.Sobrenome = pessoa2.definirSobrenome(); 
pessoa2.Idade = pessoa2.definirIdade(); 
Console.WriteLine("Informe o telefone: "); 
telefone = Console.ReadLine();
pessoa2.definirTelefone(telefone);
Console.WriteLine("Informe o celular: "); 
celular = Console.ReadLine();
pessoa2.definirCelular(celular);
Console.WriteLine("Informe o email: ");
email = Console.ReadLine();
pessoa2.definirEmail(email);
#endregion

#region p3
Console.WriteLine("*** Pessoa 3 ***");

pessoa3.Nome = pessoa3.definirNome(); 
pessoa3.Sobrenome = pessoa3.definirSobrenome(); 
pessoa3.Idade = pessoa3.definirIdade(); 
Console.WriteLine("Informe o telefone: "); 
telefone = Console.ReadLine();
pessoa3.definirTelefone(telefone);
Console.WriteLine("Informe o celular: "); 
celular = Console.ReadLine();
pessoa3.definirCelular(celular);
Console.WriteLine("Informe o email: ");
email = Console.ReadLine();
pessoa3.definirEmail(email);
#endregion
Console.WriteLine();
Console.WriteLine("*** Pessoa 1 ***");
pessoa.MostrarDados();
Console.WriteLine();
Console.WriteLine("*** Pessoa 2 ***");
pessoa2.MostrarDados();
Console.WriteLine();
Console.WriteLine("*** Pessoa 3 ***");
pessoa3.MostrarDados();*/


//Console.WriteLine(pessoa.ToString()); -> para imprimir os dados
//Console.WriteLine(pessoa.Nome);
//Console.WriteLine(pessoa.Sobrenome);
//Console.WriteLine(pessoa.Idade);
//Console.WriteLine(pessoa.Telefone);
//Console.WriteLine(pessoa.Celular);
//Console.WriteLine(pessoa.Email);






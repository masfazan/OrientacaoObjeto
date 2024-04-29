public class Pessoa
{
    public string Nome;
    public string Sobrenome;
    public int Idade;
    public string Telefone;
    public string Celular;
    public string Email;
    public Pessoa()
    {
    }
    public string definirNome() //Com retorno
    {
        Console.WriteLine("Informe o nome: ");
        return Console.ReadLine();
    }
    public string definirSobrenome() //Com retorno
    {
        Console.WriteLine("Informe o sobrenome: ");
        return Console.ReadLine();
    }
    public int definirIdade() //Com retorno
    {
        Console.WriteLine("Informe a Idade: ");
        return int.Parse(Console.ReadLine());
    }
    public void definirTelefone(string telefone) //Com parâmetro
    {
        this.Telefone = telefone; //Usando "this"
    }
    public void definirCelular(string celular) //Com parâmetro
    {
        this.Celular = celular;
    }
    public void definirEmail(string email) //Com parâmetro
    {
        this.Email = email;
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome:{Nome}",this.Nome);//this DESTE objeto, para imprimir o "Nome" antes do retorno
        Console.WriteLine($"Sobrenome:{Sobrenome}", this.Sobrenome);
        Console.WriteLine($"Idade:{Idade}", this.Idade);
        Console.WriteLine($"Telefone:{Telefone}", this.Telefone);
        Console.WriteLine($"Celular:{Celular}", this.Celular);
        Console.WriteLine($"Email:{Email}", this.Email);
    }
}

public class Pessoa
{
    public string nome;
    public string endereco;
    public string sexo;
    public string telefone;
    public float salario;
    public DateOnly nascimento;

    public Pessoa()
    {

    }
    public void DefinirNome(string n)
    {
        this.nome = n;

    }
    public void DefinirEndereco(string e)
    {
        this.endereco = e;

    }
    public void DefinirSexo(string s)
    {
        this.sexo = s;

    }
    public void DefinirTelefone(string t)
    {
        this.telefone = t;

    }
    public void DefinirSalario(float s)
    {
        this.salario = s;

    }
    public void DefinirNascimento(DateOnly d)
    {
        this.nascimento = d;

    }
    public void ImprimirPessoa()
    {
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Endereço: " + this.endereco);
        Console.WriteLine("Sexo: " + this.sexo);
        Console.WriteLine("Telefone: " + this.telefone);
        Console.WriteLine("Salario: " + this.salario);
        Console.WriteLine("Nascimento: " + this.nascimento);
    }
}


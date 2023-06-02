public class Usuario
{
    private string nome;
    private string cpf;
    private string sexo;
    private string senha;


    //Encapsulamento nome
    public void Setnome(string nome)
    {
        this.nome = nome;
    }
    public string Getnome()
    { return this.nome; }

    //Encapsulamento cpf
    public void Setcpf(string cpf)
    {
        this.cpf = cpf;
    }
    public string Getcpf()
    { return this.cpf; }

    //Encapsulamento sexo
    public void Setsexo(string sexo)
    {
        this.sexo = sexo;
    }
    public string Getsexo()
    { return this.sexo; }
    //Encapsulamento senha
    public void Setsenha(string senha)
    {
        this.senha = senha;
    }
    public string Getsenha()
    { return this.senha; }

}
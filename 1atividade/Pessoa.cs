using System.Drawing;
using System.Windows.Forms;

public class Pessoa
{
    private string nome;
    private string cpf;
    private string sexo;
    private double peso;
    private double altura;
    private int idade;

    //Encapsulamento nome
    public void Setnome(string nome)
    { this.nome = nome; }
    public string Getnome()
    { return this.nome; }

    //Encapsulamento cpf
    public void Setcpf(string cpf)
    { this.cpf = cpf; }
    public string Getcpf()
    { return this.cpf; }

    //Encapsulamento sexo
    public void Setsexo(string sexo)
    { this.sexo = sexo; }
    public string Getsexo()
    { return this.sexo; }

    //Encapsulamento peso
    public void Setpeso(double peso)
    { this.peso = peso; }
    public double Getpeso()
    { return this.peso; }

    //Encapsulamento altura
    public void Setaltura(double altura)
    { this.altura = altura; }
    public double Getaltura()
    { return this.altura; }

    //Encapsulamento idade
    public void Setidade(int idade)
    { this.idade = idade; }
    public int Getidade()
    { return this.idade; }

    public Pessoa(string nome, string cpf, string sexo, double peso, double altura, int idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;
        this.idade = idade;
    }
  
    public (double, string, string) Imc()
    {
        double calImc = (this.peso/(this.altura*this.altura));
        string classificacao;
        string grau;

        if( calImc < 18.5)
        {
            return (calImc, "MAGREZA","0");
        }
        else if(calImc> 18.5 & calImc<24.9)
        {
            return (calImc, "NORMAL", "0");
        }
        else if( calImc> 25.0 & calImc<29.9)
        {
            return (calImc, "SOBREPESO", "I");
        }
        else if(calImc> 30.0 & calImc<39.9)
        {
            return (calImc, "OBESIDADE", "II");
        }
        else 
        {
            return (calImc, "OBESIDADE GRAVE", "III");
        }
    }



}
namespace CursoDeCsharp;

public class Banco
{
    private double _saldo;
    public int NumConta { get; private set; }
    public string NomeCliente { get; set; }
    
    public Banco(string nomeCliente, int numConta, double saldo)
    {
        _saldo = saldo;
        NomeCliente = nomeCliente;
        NumConta = numConta;
    }

    public void Deposito (double valor)
    {
        _saldo += valor;
    }

    public void Saque(double valor)
    {
        _saldo -= valor + 5;
    }

    public override string ToString()
    {
        return
            $"------ DADOS DA CONTA ------ \r\nNOME DO CLIENTE: {NomeCliente} " +
            $"\r\nNUMERO DA CONTA: {NumConta} \r\nSALDO EM CONTA: {_saldo:F2} ";
    }
}
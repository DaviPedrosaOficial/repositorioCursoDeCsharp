namespace CursoDeCsharp.Cap3.Classes
{
    public class Banco
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        
        public double Saldo { get; private set; }

        public Banco(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }
        
        /* Após a revisão do exercício foi discutido a importância de se utilizar o método deposito como entrada para o nosso
        saldo, ao invés de utilizarmos apenas "Saldo += Saldo", e assim foi executado um tratamento em nossa classe.
        
        E por que seria tão importante utilizar desta maneira?
        
        Isso ocorre, devido a possíveis mudanças futuras referentes as condições de depositos. Ou seja, pode ser que em um 
        futuro, a empresa passasse a cobrar também uma taxa para fazermos depositos, o que faria com que esse deposito inicial
        utilizando apenas a nomenclatura "Saldo += saldo", não fosse taxado do mesmo!                                     */
        public Banco(string titular, int numero, double depositoInicial) : this(titular,numero)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public override string ToString()
        {
            return
                $"------ DADOS DA CONTA ------ \r\nNOME DO CLIENTE: {Titular} " +
                $"\r\nNUMERO DA CONTA: {Numero} \r\nSALDO EM CONTA: {Saldo:F2} ";
        }
    }
}
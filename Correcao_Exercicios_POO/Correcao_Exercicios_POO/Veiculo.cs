namespace Correcao_Exercicios_POO
{
    public class Veiculo
    {
        public virtual void Mover()
        {
            Console.WriteLine("Veiculo se movendo!");
        }
    }

    public class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro se movendo!");
        }
    }

    public class Bicicleta : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Bicicleta se movendo!");
        }
    }
}

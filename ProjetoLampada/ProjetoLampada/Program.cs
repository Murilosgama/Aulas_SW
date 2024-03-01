namespace ProjetoLampada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp1 = new Lampada();

            lamp1.ligar();
            lamp1.desligar();
            Console.WriteLine("A lampada está ligada?" + lamp1.estaLigada());
            


        }
    }
}
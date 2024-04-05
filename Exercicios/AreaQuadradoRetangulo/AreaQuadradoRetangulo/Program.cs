namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de area, Quadradro ou Retangulo.");
            Area area= new Area();
            Console.WriteLine("Digite o valor da base:");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O valor da area: " + area.Calcular2());

            area.MostraDetalhes();

        }
    }
}
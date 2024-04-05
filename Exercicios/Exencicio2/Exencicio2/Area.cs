namespace Exencicio2
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculo { get; set; }

        public void Escolha(int opcao)
        {
            if (opcao == 1)
            {
                float quadrado CalculoAreaQuadrado();
                Console.WriteLine("Area do quadrado é " + quadrado);
            }
            if (opcao == 2)
            {
                float retangulo CalculoAreaRetangulo();
                Console.WriteLine("Area do retangulo é " + retangulo);
            }
            if (opcao == 3)
            {
                float triangulo CalculoAreaTriangulo();
                Console.WriteLine("Area do triangulo é " + triangulo);
            }
        }

        public float CalculoAreaQuadrado()
        {
            return AreaCalculo;
        }
        public float CalculoAreaRetangulo()
        {
            return AreaCalculo;
        }
        public float CalculoAreaTriangulo()
        {
            return AreaCalculo;
        }
    }
}

namespace TrianguloPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("--- Categorizar Triângulo ---");

                Triangulo triangulo = new Triangulo();

                Console.Write("Informe a medida do lado A: ");
                triangulo.LadoA = Convert.ToDouble(Console.ReadLine()!);

                Console.Write("\nInforme a medida do lado B: ");
                triangulo.LadoB = Convert.ToDouble(Console.ReadLine()!);

                Console.Write("\nInforme a medida do lado C: ");
                triangulo.LadoC = Convert.ToDouble(Console.ReadLine()!);

                Console.Clear();

                bool ehValida = triangulo.VerificarMedidasValidas();

                if (ehValida)
                {
                    string categoria = triangulo.ObterCategoria();
                    Console.WriteLine($"As medidas informadas formam um triângulo {categoria}");
                }
                else
                {
                    Console.WriteLine("Não é possível criar um triângulo com as medidas informadas");
                }

                Console.ReadLine();

                Console.WriteLine("Deseja iniciar um novo triângulo? [1]Sim [2]Não");
                bool continuar = Console.ReadLine() == "1";
                Console.Clear();

                if (!continuar)
                    break;
            }
        }
    }
}













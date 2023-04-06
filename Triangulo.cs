using System.Diagnostics.CodeAnalysis;

namespace TrianguloPOO
{
    public struct Triangulo
    {
        public double LadoA { get; set; }

        public double LadoB { get; set; }

        public double LadoC { get; set; }

        public string ObterCategoria()
        {
            var medidas = new double[] { LadoA, LadoB, LadoC };

            int ladosDiferentes = medidas.Distinct().Count();

            return ladosDiferentes == 3 ? "Escaleno" : ladosDiferentes == 2 ? "Isósceles" : "Equilátero";
        }

        public bool VerificarMedidasValidas()
        {
            double[] valoresOrdenados = new double[] { LadoA, LadoB, LadoC }.OrderBy(i => i).ToArray();

            return (valoresOrdenados[0] + valoresOrdenados[1]) < valoresOrdenados[2] ? false : true;
        }




    }
}













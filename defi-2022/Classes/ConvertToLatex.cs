using System.IO;
using WpfMath;

namespace defi_2022.Classes
{
    class ConvertToLatex
    {
        public int counter;

        public static string CreateEquation(string latex, int counter)
        {
            string fileName = "Equations\\formula" + counter + ".png";
            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var pngBytes = formula.RenderToPng(50.0, 0.0, 0.0, "Cambria");
            File.WriteAllBytes(fileName, pngBytes);

            return fileName;
        }
    }
}

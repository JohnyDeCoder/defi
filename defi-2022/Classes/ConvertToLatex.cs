using System.IO;
using WpfMath;

namespace defi_2022.Classes
{
    class ConvertToLatex
    {
        public static string CreateEquation(string latex, int counter)
        {
            counter++;
            Properties.Settings.Default.Counter = counter; // Guarda el contenido de counter a la variable global
            string fileName = "Equations\\formula" + counter + ".png";
            Properties.Settings.Default.Save();
            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var pngBytes = formula.RenderToPng(50.0, 0.0, 0.0, "Arial");
            File.WriteAllBytes(fileName, pngBytes);

            return fileName;
        }
    }
}

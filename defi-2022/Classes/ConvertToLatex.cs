using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WpfMath;

namespace defi_2022.Classes
{
    class ConvertToLatex
    {
        public static string CreateEquation(string latex, int c)
        {
            string fileName = "Equations\\formula" + c + ".png";
            var parser = new TexFormulaParser();
            var formula = parser.Parse(latex);
            var pngBytes = formula.RenderToPng(30.0, 0.0, 0.0, "Cambria");
            File.WriteAllBytes(fileName, pngBytes);

            return fileName;
        }
    }
}

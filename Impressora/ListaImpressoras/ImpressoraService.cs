using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;

namespace ListaImpressoras
{
    public static class ImpressoraService
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool SetDefaultPrinter(string Name);

        public static string ObterImpressoraPadrao()
        {
            PrinterSettings settings = new PrinterSettings();
            return settings.PrinterName;
        }

        public static string[] ListarImpressoras()
        {
            return PrinterSettings.InstalledPrinters
                                  .Cast<string>()
                                  .ToArray();
        }

        public static bool DefinirComoPadrao(string nomeImpressora)
        {
            return SetDefaultPrinter(nomeImpressora);
        }
    }
}

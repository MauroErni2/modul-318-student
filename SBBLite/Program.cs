using SwissTransport.Core;

namespace SBBLite
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SwissTranport());

            ITransport transport = new Transport();
            Application.Run(new SwissTranport());
        }
    }
}
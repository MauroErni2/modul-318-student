using SwissTransport.Core;

namespace SBBLite3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());

                ITransport transport = new Transport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Du hast keine Internetverbindung");
            }
        }
    }
}
using GaroliBudget.Infrastructure;
using SQLitePCL;

namespace GaroliBudget
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Batteries.Init();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DBSqLite.CriarEstruturaInicial();
            Application.Run(new Menu());
        }
    }
}
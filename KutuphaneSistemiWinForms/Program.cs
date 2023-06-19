using KutuphaneSistemiWinForms.Controller;
using KutuphaneSistemiWinForms.Database.EntityFramework;
using KutuphaneSistemiWinForms.SystemData;
using KutuphaneSistemiWinForms.Displays.RezervationDisplay;
using KutuphaneSistemiWinForms.Displays.MainMenu;

namespace KutuphaneSistemiWinForms
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
            Application.Run(new MainMenuDisplay());

        }
    }
}
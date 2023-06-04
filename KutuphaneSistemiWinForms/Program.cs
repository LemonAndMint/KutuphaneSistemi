using KutuphaneSistemi.Controller;
using KutuphaneSistemi.Database.EntityFramework;
using KutuphaneSistemi.SystemData;

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

            

            /*DatabaseContext context = new DatabaseContext();
            Book createBookw = new Book();
            context.Book.Add(createBook);
            context.SaveChanges(); */
            
            //#TODO Datalari ekle 

            ApplicationConfiguration.Initialize();
            Application.Run(new BookRegisterDisplay());

        }
    }
}
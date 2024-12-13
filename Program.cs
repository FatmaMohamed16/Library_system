using Library_Management_System.Data;
using Library_Management_System.Data;
namespace Library_Management_System
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
            //Application.Run(new MainForm());
            Application.Run(new StartingForm());
            //Application.Run(new AddBookForm());
            //Application.Run(new BooksListForm());
            //Application.Run(new RegesterationForm());
            //Application.Run(new ManageUsersForm());
        }
    }
}
<<<<<<< HEAD:login/Program.cs
namespace Login
=======
namespace forms1
>>>>>>> 85d66f729229871f34c2bb35a95a8928b9b31cf3:forms1/Program.cs
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
            Application.Run(new FormLogin());
        }
    }
}
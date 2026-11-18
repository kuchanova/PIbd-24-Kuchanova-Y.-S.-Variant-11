using Unity;

namespace LibraryApp
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
            var container = ContainerConfig.Configure();
            var mainForm = container.Resolve<MainForm>();
            Application.Run(mainForm);
        }
    }
}
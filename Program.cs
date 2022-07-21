namespace Nimo_Cinema
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
            Application.Run(new loginForm());
        }

        private static string _UserName = null;
        public static string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private static string _Price = null;
        public static string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
    }
}
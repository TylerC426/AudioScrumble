namespace MediocreSoundDesigner
{
    internal static class Program
    {
        public static bool isDarkMode { get; set; } = true;
        public static Color darkBackground = Color.FromArgb(18, 16, 24);
        public static Color lightBackground = Color.FromArgb(206, 234, 215);
        public static Color darkForeground = Color.FromArgb(41, 55, 71);
        public static Color lightForeground = Color.FromArgb(66, 91, 88);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}
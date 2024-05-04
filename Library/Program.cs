namespace Library
{
    //Victor Rafael da Silva
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
            Application.Run(new Form1());

            List<Exemplar> exemplars = new List<Exemplar>();
            List<Leitor> leitores = new List<Leitor>();
            List<Funcionario> funcionarios = new List<Funcionario>();
        }
    }
}
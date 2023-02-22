namespace Quiz_Windows_Forms
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
         
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmIniciar());
        }
    }
}
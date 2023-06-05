namespace MediaTek86;
using System;
using System.Windows.Forms;
using MediaTek86.views;
using Serilog;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();

        Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .Enrich.FromLogContext()
        .WriteTo.Console()
        .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
        .CreateLogger();

        Application.Run(new ConnectForm()); // view

        Log.CloseAndFlush();
    }    
}
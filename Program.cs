namespace MediaTek86;
using System;
using System.Windows.Forms;
using MediaTek86.views;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();
        Application.Run(new StaffListForm()); // view
    }    
}
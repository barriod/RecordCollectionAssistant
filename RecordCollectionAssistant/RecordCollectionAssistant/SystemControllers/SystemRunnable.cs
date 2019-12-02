using System;
using System.Windows.Forms;
using RecordCollectionAssistant.UIForms;

namespace RecordCollectionAssistant.SystemControllers
{
    /// <summary>
    /// This class runs the main form and starts the program.
    /// </summary>
    public static class RecordManager
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ListRecordForm(controller));
            Application.Run(new LoginForm());
        }
    }
}

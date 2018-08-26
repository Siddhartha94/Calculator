using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBAC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine(InfixEvaluation.evaluate("10 + 2 * 6"));
            //System.out.println(EvaluateString.evaluate("100 * 2 + 12"));
            //System.out.println(EvaluateString.evaluate("100 * ( 2 + 12 )"));
            //System.out.println(EvaluateString.evaluate("100 * ( 2 + 12 ) / 14"));
            Application.Run(new FormCalculator());
        }
    }
}

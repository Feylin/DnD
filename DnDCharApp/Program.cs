using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharApp
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
            //Application.Run(new CharacterSheet());
            //Application.Run(new CharacterAbilityScores());
            Application.Run(new MultiFormContext(new CharacterSheet(), new CharacterAbilityScores()));
        }
    }
}

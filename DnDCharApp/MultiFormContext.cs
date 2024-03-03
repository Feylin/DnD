using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharApp
{
    public class MultiFormContext : ApplicationContext
    {
        private int _openForms;
        public MultiFormContext(params Form[] forms)
        {
            _openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    //When we have closed the last of the "starting" forms, 
                    //end the program.
                    if (Interlocked.Decrement(ref _openForms) == 0)
                        ExitThread();
                };

                form.Show();
            }
        }
    }
}

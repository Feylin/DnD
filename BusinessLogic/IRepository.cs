using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessLogic
{
    public interface IRepository
    {
        int Random(int min, int max);

        BE_Race[] Races();

        BE_Class[] Classes();
    }
}

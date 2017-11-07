using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Softwere_evolution
{
    public interface IStrategyBonus
    {
        double StandartBonusValue(Item item, ReadConfingfile readConfingfile);
        double FestiveBonusValue(Item item, ReadConfingfile readConfingfile);
    }
}

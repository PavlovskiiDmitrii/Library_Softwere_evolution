﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Softwere_evolution
{
    public interface IStrategyDiscount
    {
        double StandartDiscountValue(Item item, ReadConfingfile readConfingfile);
        double FestiveDiscountValue(Item item, ReadConfingfile readConfingfile);
    }
}

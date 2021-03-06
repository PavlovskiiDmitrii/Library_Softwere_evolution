﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Softwere_evolution
{
    public enum Typeofdiscount
    {
        RegularGoods,
        SaleGoods,
        SpecialGoods
    }
    public class BillFactory
    {
        Goods _goods;
        ReadConfingfile ConfingValue = new ReadConfingfile();
        // <<ФАБРИЧНЫЙ МЕТОД>>
        public Goods Create(Typeofdiscount id, string title)
        {
            if (id == Typeofdiscount.RegularGoods)
            {
                return _goods = new Goods(title, Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            }
            if (id == Typeofdiscount.SaleGoods)
            {
                return _goods = new Goods(title, Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            }
            if (id == Typeofdiscount.SpecialGoods)
            {
                return _goods = new Goods(title, Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            }
            return null;
        }
    }
}

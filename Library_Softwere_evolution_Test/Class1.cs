using System;
using Library_Softwere_evolution;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Softwere_evolution_Test
{
    [TestFixture]
    public class Class1
    {
        ReadConfingfile ConfingValue = new ReadConfingfile();
        [Test]
        public void RegLess1_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
    }
}

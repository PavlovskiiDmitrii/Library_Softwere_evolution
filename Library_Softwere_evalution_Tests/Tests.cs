using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Softwere_evolution;
using NUnit.Framework;

namespace Library_Softwere_evalution_Tests
{
    [TestFixture]
    public class Tests
    {
        ReadConfingfile ConfingValue = new ReadConfingfile();
        ReadConfingfile ConfingValueNY = new ReadConfingfile("NY");

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
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t1\t65\t   0\t 65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void RegMore2_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 10);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t6\t390\t   21,7\t 368,3\t19\nСумма счета составляет 368,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleLess3_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 2, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t2\t76\t   0\t 76\t0\nСумма счета составляет 76\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialLess10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 8, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t8\t184\t   0\t 184\t0\nСумма счета составляет 184\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SpecialMore10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 13, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t13\t299\t   14,95\t 284,05\t0\nСумма счета составляет 284,05\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void SaleMore3()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t7\t266\t   2,66\t 263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BRegular()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 8, 40);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t40\t8\t320\t   9,6\t 310,4\t16\nСумма счета составляет 310,4\nВы заработали 16 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BsSale()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 20, 36);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t36\t20\t720\t   7,2\t 712,8\t7\nСумма счета составляет 712,8\nВы заработали 7 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void BSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 2, 93);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t93\t2\t186\t   0\t 186\t0\nСумма счета составляет 186\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
        [Test]
        public void UseBRegularLess5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 20);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t1\t65\t   0\t 65\t3\nСумма счета составляет 45\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValue);
            Item i1 = new Item(Cola, 10, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t10\t230\t   0\t 230\t0\nСумма счета составляет 230\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBRegularMore5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 30);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t6\t390\t   41,7\t 348,3\t19\nСумма счета составляет 348,3\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void UseBSaleMore1()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t7\t266\t   2,66\t 263,34\t2\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void HTMLPresenter()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValue);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new HTMLPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\n\t|Название|\t|Цена|\t|Кол-во||Стоимость|\t|Скидка||Сумма|\t|Бонус|\n\t|Cola|\t\t|38|\t|7|\t|266|\t\t|2,66|\t|263,34|\t|2|\nСумма счета составляет 263,34\nВы заработали 2 бонусных балов";
            Assert.AreEqual(expected, bill);
        }


        /// СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        /// СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        /// СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        /// СПЕЦИАЛЬНЫЕ СКИДКИ \\\
        /// СПЕЦИАЛЬНЫЕ СКИДКИ \\\


        public void NYRegLess1_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-воСтоимость\tСкидка\tСумма\tБонус\n\tCola\t\t65\t1\t65\t0\t65\t3\nСумма счета составляет 65\nВы заработали 3 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYRegMore2_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 10);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t6\t390\t   25,6\t 364,4\t23\nСумма счета составляет 364,4\nВы заработали 23 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSaleLess3_()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 2, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t2\t76\t   0\t 76\t0\nСумма счета составляет 76\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSpecialLess10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(Cola, 8, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t8\t184\t   0\t 184\t0\nСумма счета составляет 184\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSpecialMore10()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(Cola, 13, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t13\t299\t   0\t 299\t0\nСумма счета составляет 299\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYSaleMore3()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t7\t266\t   0\t 266\t0\nСумма счета составляет 266\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBRegular()
        {

            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 8, 40);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t40\t8\t320\t   12,8\t 307,2\t19\nСумма счета составляет 307,2\nВы заработали 19 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBsSale()
        {
            ReadConfingfile ConfingValueNY = new ReadConfingfile("NY");
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 20, 36);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t36\t20\t720\t   14,4\t 705,6\t14\nСумма счета составляет 705,6\nВы заработали 14 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(Cola, 2, 93);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t93\t2\t186\t   0\t 186\t0\nСумма счета составляет 186\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
        [Test]
        public void NYUseBRegularLess5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 1, 65);
            Customer x = new Customer("test", 20);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t1\t65\t   0\t 65\t0\nСумма счета составляет 45\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBSpecial()
        {
            Goods Cola = new Goods("Cola", Typeofdiscount.SpecialGoods, new SpecialStrategyBonus(), new SpecialStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(Cola, 10, 23);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t23\t10\t230\t   0\t 230\t0\nСумма счета составляет 230\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBRegularMore5()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.RegularGoods, new RegularStrategyBonus(), new RegularStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 6, 65);
            Customer x = new Customer("test", 30);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t65\t6\t390\t   45,6\t 344,4\t23\nСумма счета составляет 344,4\nВы заработали 23 бонусных балов";
            Assert.AreEqual(expected, bill);
        }

        [Test]
        public void NYUseBSaleMore1()
        {
            Goods cola = new Goods("Cola", Typeofdiscount.SaleGoods, new SaleStrategyBonus(), new SaleStrategyDiscount(), ConfingValueNY);
            Item i1 = new Item(cola, 7, 38);
            Customer x = new Customer("test", 0);
            IPresenter p = new TXTPresenter();
            Bill b1 = new Bill(x, p);
            b1.addGoods(i1);
            string bill = b1.statement();
            string expected = "Счет для test\n\tНазвание\tЦена\tКол-во  Стоимость Скидка Сумма\tБонус\n\tCola\t\t38\t7\t266\t   0\t 266\t0\nСумма счета составляет 266\nВы заработали 0 бонусных балов";
            Assert.AreEqual(expected, bill);
        }
    }
}


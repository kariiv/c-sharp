
using System;
using NUnit.Framework;
using System.Collections.Generic;
namespace Praktikum8
{
    [TestFixture]
    public class MoneyTest
    {
        private Money _12EUR;
        private Money _14EUR;
        private Money _7USD;
        private Money _21USD;/*
        private Wallets Wallet1;
        private Wallets Wallet2;*/
        [SetUp]
        public void SetUp()
        {
            _12EUR = new Money(12, "EUR");
            _14EUR = new Money(14, "EUR");
            _7USD = new Money(7, "USD");
            _21USD = new Money(21, "USD");/*
            Wallet1 = new Wallets(_12EUR);
            Wallet2 = new Wallets(_14EUR);*/
        }
        [Test]
        public void TestMoneyEquality()
        {
            Assert.IsTrue(_12EUR.AreEqual(new Money(12, "EUR")));

        }
        [Test]
        public void SimpleAdd() //Test adding money
        {
            // [12 EUR] + [14 EUR] == [26 EUR]
            Money expected = new Money(26, "EUR");
            Money added = _12EUR.AddMoney(_14EUR);
            Assert.IsTrue(expected.AreEqual(added));
        }
        [Test]
        public void MoneyMultiply()
        {
            // [14 EUR] *2 == [28 EUR]
            Money expected = new Money(28, "EUR");
            Money multiply = _14EUR.MultMoney(2);
            Assert.IsTrue(multiply.AreEqual(expected));
        }
        [Test]
        public void MoneyNegate()
        {
            // [14 EUR] negate == [-14 EUR]
            Money expected = new Money(-14, "EUR");
            Money negate = _14EUR.Negate();
            Assert.IsTrue(negate.AreEqual(expected));
        }
        [Test]
        public void MoneySubtract()
        {
            // [14 EUR] -[4 EUR] == [10 EUR]
            Money expected = new Money(10, "EUR");
            Money dev = new Money(4, "EUR");
            Money DevMoney = _14EUR.DevMoney(dev);
            Assert.IsTrue(expected.AreEqual(DevMoney));
        }
        [Test]
        public void PrintMoney()
        {
            // [12 EUR] -> "12EUR"
            string expected = "12EUR";
            Assert.IsTrue(expected == _12EUR.PrintMoney());
        }
        [Test]
        public void WalletContainsValue()
        {
            //Create a wallet containing _12EUR
            //Find euros from wallet and see if the value is 12EUR
            Wallet walletWith12Euros = new Wallet(_12EUR);
            Money moneyFromWallet = walletWith12Euros.FindMoney("EUR");



        }
        [Test]
        public void MoneyWasAddedToWallet()
        {
            // {[12 EUR]} + [14 EUR] == [26 EUR]
        }
        [Test]
        public void AreTwoWalletsEqual()
        {
            // {[12 EUR], [14EUR]} == { [14EUR], [12EUR]} 
        }
        [Test]
        public void WalletSimpleAdd() //Add money to Wallet
        {
            // {[12 EUR][7 USD]} + [14 EUR] == {[26 EUR][7 USD]}
        }
        [Test]
        public void WalletMultiply()
        {
            // {[12 EUR][7 USD]} *2 == {[24 EUR][14 USD]}
        }
        [Test]
        public void WalletNegate()
        {
            // {[12 EUR][7 USD]} negate == {[-12 EUR][-7 USD]}
        }
        [Test]
        public void WalletSumAdd() //add 2 Wallets
        {
            // {[12 EUR][7 USD]} + {[14 EUR][21 USD]} == {[26 EUR][28 USD]}

        }
        [Test]
        public void SubtractMoneyFromWallet()
        {
            // [14 EUR][26USD] - [10EUR] == [4 EUR][26USD]
        }
        [Test]
        public void SubtractWalletFromWallet()
        {
            // [14 EUR][26USD] - [10EUR][6USD] == [4 EUR][20USD]
        }
    }
}
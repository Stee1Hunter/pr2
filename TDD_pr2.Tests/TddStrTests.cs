using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TDD_pr2.Tests
{
    [TestClass]
    public class TddStrTests
    {
        [TestMethod]
        public void word_Shortword_returnI()
        {
            string Stroka = "Я люблю танки!!!!";
            string expected = "Я";
            TddStr classtdd = new TddStr();
            string actual = classtdd.word(Stroka);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void wordcount_wordcount_returnCountofWords()
        {
            string Stroka = "Я люблю танки!!!!";
            int expected = 2;
            TddStr classtdd = new TddStr();
            int actual = classtdd.wordcount(Stroka);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void countofsimbols_simbolcount_returnCountofsimbols()
        {
            string Stroka = "Я люблю танки!!!!";
            int expected = 16;
            TddStr classtdd = new TddStr();
            int actual = classtdd.simbolcount(Stroka);
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void simbol9_simbo9_simbol()
        {
            string Stroka = "Я люблю танки!!!!";
            int simbol = 9;
            string expected = "т";
            TddStr classtdd = new TddStr();
            string actual = classtdd.ninesimbol(Stroka, simbol);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cifracount_countofcifra_0()
        {
            string Stroka = "Я люблю танки!!!!";
            int expected = 0;
            TddStr classtdd = new TddStr();
            int actual = classtdd.cifracount(Stroka);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void cifracountpodr_countofcifrapodrad_0()
        {
            string Stroka = "123Я любл11234ю тан12ки!!!!";
            int expected = 5;
            TddStr classtdd = new TddStr();
            int actual = classtdd.cifracountpodr(Stroka);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void countpodcombcount_countofcombinations_2()
        {
            string Stroka = "Я люблю танки и что-то ещё!!!!";
            string comb = "лю";
            int expected = 2;
            TddStr classtdd = new TddStr();
            int actual = classtdd.countpodcombcount(Stroka, comb);
            Assert.AreEqual(expected, actual);
        }
    }
}

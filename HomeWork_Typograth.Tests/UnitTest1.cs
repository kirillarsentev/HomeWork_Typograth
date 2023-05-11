using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Typograth_Application;

namespace HomeWork_Typograth.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RuleDefisTest1()
        {
            string in_str = "Книга — источник знания";
            string excepted = "Книга-источник знания";

            Form1 main = new Form1();

            string actual = main.defis(in_str);

            Assert.AreNotEqual(excepted, actual);
        }

        [TestMethod]
        public void SpaceTest1()
        {
            string in_str = "word  word";
            string excepted = "word word";

            Form1 main = new Form1();

            string actual = main.space(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void RuleSpaceTest2()
        {
            string in_str = "word  word  word";
            string excepted = "wordword word";

            Form1 main = new Form1();

            string actual = main.space(in_str);

            Assert.AreNotEqual(excepted, actual);
        }
        [TestMethod]
        public void RuleSpaceTest3()
        {
            string in_str = "wordwordword";
            string excepted = "word word word";

            Form1 main = new Form1();

            string actual = main.space(in_str);

            Assert.AreNotEqual(excepted, actual);
        }


        [TestMethod]
        public void dots_Test1()
        {
            string in_str = "...";
            string excepted = "\u2026";

            Form1 main = new Form1();

            string actual = main.dots(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void dots_Test2()
        {
            string in_str = "...";
            string excepted = "\u2026" + "..";

            Form1 main = new Form1();

            string actual = main.dots(in_str);

            Assert.AreNotEqual(excepted, actual);
        }
        [TestMethod]
        public void dots_Test3()
        {
            string in_str = "....";
            string excepted = "\u2026";

            Form1 main = new Form1();

            string actual = main.dots(in_str);

            Assert.AreNotEqual(excepted, actual);
        }
        [TestMethod]

        public void PlusMinus_Test1()
        {
            string in_str = "1+-2";
            string excepted = "1±2";

            Form1 main = new Form1();

            string actual = main.plus_minus(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]

        public void PlusMinus_Test2()
        {
            string in_str = "1-+2";
            string excepted = "1±2";

            Form1 main = new Form1();

            string actual = main.plus_minus(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]

        public void MaternoeSlovo_Test1()
        {
            string in_str = "мат";
            string excepted = "***";

            Form1 main = new Form1();

            string actual = main.maternoye_slovo(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]

        public void MaternoeSlovo_Test2()
        {
            string in_str = "хорошее слово";
            string excepted = "***";

            Form1 main = new Form1();

            string actual = main.maternoye_slovo(in_str);

            Assert.AreNotEqual(excepted, actual);
        }
        [TestMethod]

        public void MaternoeSlovo_Test3()
        {
            string in_str = "брань";
            string excepted = "***";

            Form1 main = new Form1();

            string actual = main.maternoye_slovo(in_str);

            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]

        public void MaternoeSlovo_Test4()
        {
            string in_str = "ругань";
            string excepted = "***";

            Form1 main = new Form1();

            string actual = main.maternoye_slovo(in_str);

            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]

        public void BestTeacher_Test1()
        {
            string in_str = "Дина Сергеевна";
            string excepted = "Лучший препод";

            Form1 main = new Form1();

            string actual = main.best_teachers(in_str);

            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]

        public void BestTeacher_Test2()
        {
            string in_str = "Любой другой препод";
            string excepted = "Лучший препод";

            Form1 main = new Form1();

            string actual = main.best_teachers(in_str);

            Assert.AreNotEqual(excepted, actual);
        }









    }
}

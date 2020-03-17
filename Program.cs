using System;
using System.Collections.Generic;
using System.Threading.Channels;
using NUnit.Framework;

namespace NET.S._2020.Aristova._02
{
    class Program
    {

        [Test]
        public void InsertNum()
        {
            //Console.WriteLine(WorkWithNumber.InsertNumber(15, 15, 0, 0));
            bool isEquals = false || WorkWithNumber.InsertNumber(15, 15, 0, 0) == 15;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.InsertNumber(8, 15, 0, 0) == 9;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.InsertNumber(8, 15, 3, 8) == 120;
            Assert.IsTrue(isEquals);
            //Assert.Equals(WorkWithNumber.InsertNumber(8, 15, 0, 0), 9);
            //Assert.Equals(WorkWithNumber.InsertNumber(8, 15, 3, 8), 120);
        }

        [Test]
        public void FindNextBiggerNumber()
        {
            bool isEquals = false || WorkWithNumber.FindNextBiggerNumber(12)  == 21;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(513) == 531;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(2017) == 2071;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(414) == 441;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(144) == 414;
            Assert.IsTrue(isEquals);


            isEquals = false || WorkWithNumber.FindNextBiggerNumber(1234321) == 1241233;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(1234126) == 1234162;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(3456432) == 3462345;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(10) == -1;
            Assert.IsTrue(isEquals);

            isEquals = false || WorkWithNumber.FindNextBiggerNumber(20) == -1;
            Assert.IsTrue(isEquals);

        }

        [Test]
        public void FilterDigit()
        {
            List<int> list = WorkWithNumber.FilterDigit(new int[] { 7, 2, 34, 52, 70 }, 7);
            Assert.AreEqual(list, new List<int>() {7, 70});

            Assert.Catch(typeof(NullReferenceException), () => WorkWithNumber.FilterDigit(null, 8));

        }
        [Test]
        public void FindNthRoot()
        {
            double x = Math.Round(WorkWithNumber.FindNthRoot(5, 1), 2);
            Assert.AreEqual(x, 1);

            x = Math.Round(WorkWithNumber.FindNthRoot(3, 8), 2);
            Assert.AreEqual(x, 2);

            x = Math.Round(WorkWithNumber.FindNthRoot(3, 0.001), 2);
            Assert.AreEqual(x, 0.1, 0.01);

            x = Math.Round(WorkWithNumber.FindNthRoot(4, 0.04100625), 2);
            Assert.AreEqual(x, 0.45, 0.001);

            x = Math.Round(WorkWithNumber.FindNthRoot(7, 0.0279936), 2);
            Assert.AreEqual(x, 0.6, 0.001);

            x = Math.Round(WorkWithNumber.FindNthRoot(4, 0.0081), 2);
            Assert.AreEqual(x, 0.3, 0.001);

            x = Math.Round(WorkWithNumber.FindNthRoot(3, -0.008), 2);
            Assert.AreEqual(x, -0.2, 0.001);

            x = Math.Round(WorkWithNumber.FindNthRoot(9, 0.004241979, 0.00000001), 3);
            Assert.AreEqual(x, 0.545, 0.0001);
        }

    }
}

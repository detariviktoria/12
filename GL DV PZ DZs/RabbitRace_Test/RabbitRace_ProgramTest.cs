using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2025_05_14_CodinGame;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace RabbitRace_Test
{
    [TestFixture]
    internal class RabbitRace_ProgramTest
    {
        RabbitRace r;
        [SetUp]
        public void Setup()
        {
            r = new RabbitRace("50 150 7 11 303".Split(' '));
        }

        [Test]
        public void Correct_RunTest()
        {
            ClassicAssert.AreEqual("278", r.Run());
        }

        [Test]
        public void UnCorrect_RunTest()
        {
            r.m = -2;
            ClassicAssert.AreEqual("Impossible", r.Run());
        }

        public void UnCorrect_RunTest2()
        {
            r.x = -2;
            ClassicAssert.AreEqual("Impossible", r.Run());
        }

        [Test]
        public void Correct_XTest()
        {
            r.x = 300;
            r.L = 299;
            ClassicAssert.AreEqual(true, r.XY(ref r.x, r.L));
        }

        [Test]
        public void Uncorrect_XTest()
        {
            r.x = 299;
            r.L = 300;
            ClassicAssert.AreEqual(false, r.XY(ref r.x, r.L));
        }

        [Test]
        public void Correct_YTest()
        {
            r.y = 300;
            r.L = 299;
            ClassicAssert.AreEqual(true, r.XY(ref r.y, r.L));
        }

        [Test]
        public void Uncorrect_YTest()
        {
            r.y = 299;
            r.L = 300;
            ClassicAssert.AreEqual(false, r.XY(ref r.y, r.L));
        }

        [TearDown]
        public void TearDown()
        {
            r = null;
        }
    }
}

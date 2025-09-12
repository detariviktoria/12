using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2025_05_14_CodinGame;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace RabbitRace_Test
{
    [TestFixture]
    internal class TestWithFiles
    {
        [TestCase(0, "4")]
        [TestCase(1, "3")]
        [TestCase(2, "278")]
        [TestCase(3, "200")]
        [TestCase(4, "499")]
        [TestCase(5, "191")]
        [TestCase(6, "950")]
        [TestCase(7, "49")]
        [TestCase(8, "2099999978")]
        [TestCase(9, "Impossible")]
        [TestCase(10, "1999999995")]
        [TestCase(11, "833333351")]
        [TestCase(12, "783950624")]
        [TestCase(13, "651898735")]

        public void Tests(int index, string expected)
        {
            List<string> lines = File.ReadAllLines($"Files/Test{index+1}.txt").ToList();
            RabbitRace r = new RabbitRace(lines[0].Split(' '));
            ClassicAssert.AreEqual(expected, r.Run());
        }
    }

}

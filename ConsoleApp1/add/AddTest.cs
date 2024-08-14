using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace ConsoleApp1.add
{
    [TestFixture]
    public class AddTest
    {
        private Add _add;
        [SetUp]
        public void Setup()
        {
            _add = new Add();
        }
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = _add.add(3, 4);
            ClassicAssert.AreEqual(7, result);
        }
    }
}


using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._10926
{
    [TestFixture]
    public class _10926Test
    {
        private _10926 _10926;
        [SetUp]
        public void Setup()
        {
            _10926 = new _10926();
        }
        [Test]
        public void test1()
        {
            String result = _10926.SurpriseManufacturing("joonas");
            ClassicAssert.AreEqual("joonas??!", result);
        }
        [Test]
        public void test2()
        {
            String result = _10926.SurpriseManufacturing("baekjoon");
            ClassicAssert.AreEqual("baekjoon??!", result);
        }
    }
}

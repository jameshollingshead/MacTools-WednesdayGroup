using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CtoFConverter;
using NUnit.Framework;

namespace CtoFTests
{
    [TestFixture]
    public class CtoFUnitTests
    {
        public CToF Converter;
        public double delta = 0.01;

        [SetUp]
        public void SetUp()
        {
            Converter = new CToF();
        }

        [Test]
        public void Negative40CItShouldBeNegative40F()
        {
            Assert.AreEqual(-40.0, Converter.CtoF(-40.0), delta);
        }

        [Test]
        public void Negative30CItShouldBeNegative22F()
        {
            Assert.AreEqual(-22.0, Converter.CtoF(-30.0), delta);
        }


    }
}

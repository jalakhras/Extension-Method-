using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.LegacyExtensions;
using System;

namespace Sixeyed.Extensions.Tests.LegacyExtensions
{
    [TestClass]
    public class LegacyExtensionsTest
    {
        [TestMethod]
        //C=>a century
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }
        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyName()
        {
            var name = "Jassar Mahmoud";
            Assert.AreEqual("MAHMOUD, JASSAR", name.ToLegacyFormat());
        }
    }
}

﻿using System;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sixeyed.Extensions.Tests.PiggybackingForXmlDateTime
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void ToXmlDateTime()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951Z", dateTime.ToXmlDateTime());
        }

        [TestMethod]
        public void ToXmlDateTime_Local()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951+03:00", dateTime.ToXmlDateTime(XmlDateTimeSerializationMode.Local));
            Assert.AreEqual("2013-10-24T13:10:15.951+03:00", DateTimeExtensions.ToXmlDateTime(dateTime, XmlDateTimeSerializationMode.Local));
        }
    }
}



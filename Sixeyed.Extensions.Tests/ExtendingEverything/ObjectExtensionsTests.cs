using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.ExtendingEverything;
using Sixeyed.Extensions.ExtendingInterfaces;
using Sixeyed.Extensions.ExtendingInterfaces.Implementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sixeyed.Extensions.Tests.ExtendingEverything
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ToJsonStringTests()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.ToJsonString());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.ToJsonString());

            var obj3 = new ReferenceDataItem
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3 - " + obj3.ToJsonString());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource> { new SqlReferenceDataSource() };
            Debug.WriteLine("obj4 - " + obj4.ToJsonString());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.ExtendingInterfaces;
using Sixeyed.Extensions.ExtendingInterfaces.Implementation;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sixeyed.Extensions.Tests.ExtendingCollections
{
    [TestClass]
    public class IReferenceDataSourceCollectionExtensionsTests
    {
        [TestMethod]
        public void GetAllItemsByCode_Array()
        {
            var sources = new IReferenceDataSource[] { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_ArrayList()
        {
            var sources = new ArrayList() { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            sources.Add("i am not a reference data source");
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_IEnumerable()
        {
            var sources = new HashSet<IReferenceDataSource> { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }
    }
}

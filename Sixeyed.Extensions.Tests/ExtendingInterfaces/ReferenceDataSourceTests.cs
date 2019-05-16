using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.ExtendingInterfaces;
using Sixeyed.Extensions.ExtendingInterfaces.Implementation;
using System.Linq;

namespace Sixeyed.Extensions.Tests.ExtendingInterfaces
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode_Sql()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [TestMethod]
        public void GetItemsByCode_Xml()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }
    }
}
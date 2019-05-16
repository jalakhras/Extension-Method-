using System.Collections.Generic;
using System.Linq;

namespace Sixeyed.Extensions.ExtendingInterfaces
{
    public static class IReferenceDataSourceExtensions
    {
        public static IEnumerable<ReferenceDataItem> GetItemsByCode(this IReferenceDataSource source, string code)
        {
            return source.GetItems().Where(x => x.Code == code);
        }
    }
}
using System.Collections.Generic;

namespace Sixeyed.Extensions.ExtendingInterfaces
{
    public interface IReferenceDataSource
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}

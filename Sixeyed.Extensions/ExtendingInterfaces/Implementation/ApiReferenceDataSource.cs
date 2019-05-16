﻿using System.Collections.Generic;

namespace Sixeyed.Extensions.ExtendingInterfaces.Implementation
{
    public abstract class ApiDataSource
    {
        public string Name = "API";
    }
    public class ApiReferenceDataSource : ApiDataSource, IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem>
            {
                new ReferenceDataItem { Code="xyz", Description="from API"},
                new ReferenceDataItem { Code="xyz", Description="from API 2"}
            };
        }
    }
}

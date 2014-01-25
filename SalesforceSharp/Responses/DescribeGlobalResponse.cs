using System.Collections.Generic;

namespace SalesforceSharp.Responses
{
    public class DescribeGlobal
    {
        public string Encoding { get; set; }
        public List<Describe> SObjects { get; set; }
        public int MaxBatchSize { get; set; }
    }
}
namespace SalesforceSharp.Responses
{
    public class QueryResponse<T> where T : new()
    {
        public int TotalSize { get; set; }
        public bool Done { get; set; }
    }
}

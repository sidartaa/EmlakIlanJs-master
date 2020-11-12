namespace Torbali.Core.Common.Contracts.RequestMessages
{
    public class BinaYasiSearchRequest
    {
        public int skip { get; set; }
        public int take { get; set; }
        public string ProductName { get; set; }
    }
}

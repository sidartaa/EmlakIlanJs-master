namespace Torbali.Core.Common.Contracts
{
    public interface ICacheProvider
    {
        void Set(string key, object value, int expiresAsMinute);
        T Get<T>(string key);
        void Remove(string key);
        bool IsExist(string key);
    }
}

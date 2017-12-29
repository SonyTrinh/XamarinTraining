namespace Refactor2.Service.Interface
{
    public interface IParser
    {
        T Deserialize<T>(string obj);

        object Serialize(object obj);
    }
}

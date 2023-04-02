namespace StockWatcher.Classes
{
    public interface IObserver<T>
    {
        void Update(T data);
    }
}

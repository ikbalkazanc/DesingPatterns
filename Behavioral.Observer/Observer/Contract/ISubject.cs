namespace Behavioral.Observer.Contract
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void TriggerObservers();
    }
}

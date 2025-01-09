namespace Patterns 
{
  // the class that will subscribe/observe to the subject
  public interface Observer 
  {
    void OnUpdate(string message);
  }

  // the class that will emit updates to all observers it has access to
  public class Subject
  {
    private readonly List<Observer> _observers = new List<Observer>();

    // subscribe
    public void Attach(Observer observer) 
    {
      _observers.Add(observer);
    }

    // unsubscribe
    public void Detach(Observer observer) 
    {
      _observers.Remove(observer);
    }

    // update all subscribers
    public void Notify(string message) 
    {
      _observers.ForEach(observer => observer.OnUpdate(message));
    }
  }

  // class that is listening for the OnUpdate call from the Subject
  public class ConcreteObserver : Observer
  {
    private readonly string _observerName;
    public ConcreteObserver(string observerName)
    {
      _observerName = observerName;
    }

    public void OnUpdate(string message) 
    {
      Console.WriteLine($"{_observerName} received update: {message}");
    }
  }
}

namespace Patterns {
  class Entry {
    public static void Main(string[] args) {
      // 1. Singleton
      Console.WriteLine("1. Singleton");
      Console.WriteLine();
      Singleton val = Singleton.Instance;

      val.Log();
      val.Log();
      val.Log();

      // 2. Shape
      Console.WriteLine();
      Console.WriteLine("2. Shape");
      Console.WriteLine();
      
      // we here create a circle without needing to know what parameters
      // circle needs
      Shape shape1 = Factory.GetShape("circle");
      shape1.Draw();  

      Shape shape2 = Factory.GetShape("square");
      shape2.Draw(); 

      // 3. Adapter
      Console.WriteLine();
      Console.WriteLine("3. Adapter");
      Console.WriteLine();

      IncompatibleService incompatible = new IncompatibleService();
      // we've adapted IncompatibleService -> TargetService
      // we can now use it as we need
      // we can think of this as a explicit cast from one type to another where
      // the properties and methods of both are not the same
      TargetService target = new Adapter(incompatible);
      Console.WriteLine($"Type of adapted class: {target.GetType()}");
      Console.WriteLine("This class is also of type Target, c#'s GetType() method doesn't reflect it at runtime.");

      // 4. Command
      Console.WriteLine();
      Console.WriteLine("4. Command");
      Console.WriteLine();

      Receiver receiver = new Receiver();
      ConcreteCommand command = new ConcreteCommand(receiver);
      Invoker invoker = new Invoker();

      // the invoker can be more complex than this, see CommandAdapter.cs for more details
      invoker.SetCommand(command);
      invoker.RunCommand();

      // 5. Observer
      Console.WriteLine();
      Console.WriteLine("5. Observer");
      Console.WriteLine();

      // Create the subject
      Subject subject = new Subject();

      // Create observers
      ConcreteObserver observerA = new ConcreteObserver("Observer A");
      ConcreteObserver observerB = new ConcreteObserver("Observer B");

      // Attach observers to the subject
      subject.Attach(observerA);
      subject.Attach(observerB);

      // Notify observers of a change
      subject.Notify("First update!");

      // Detach one observer and send another notification
      subject.Detach(observerA);
      subject.Notify("Second update!");
    }
  }
}

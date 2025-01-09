namespace Patterns
{
  // a command is simply an object we can pass around that runs some code in this example
  public interface Command 
  {
    void Execute();
  }

  // the class who'se code we're running in this example
  public class Receiver 
  {
    public void Action() 
    {
      Console.WriteLine("Receiver: Action is happening here");
    }
  }

  // the actual command definition. We can have multiple commands that do different things
  public class ConcreteCommand : Command 
  {
    private readonly Receiver _receiver;

    public ConcreteCommand(Receiver receiver) 
    {
      _receiver = receiver;
    }
    
    public void Execute() 
    {
      _receiver.Action();
    }
  }

  // this class can take any command and run it
  // a more complex example could have a queue of different commands (that extend the Command interface)
  // and runs them in order
  public class Invoker
  {
    private Command? _command;

    public void SetCommand(Command command) 
    {
      _command = command;
    }

    public void RunCommand() 
    {
      if (_command == null) {
        Console.WriteLine("No command set to execute, returning.");
        return;
      }
      
      _command.Execute();
    }
  }
}

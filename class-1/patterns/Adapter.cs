namespace Patterns 
{
  public interface TargetService // the class we want to use or need
  {
    string GetRequest();
  }

  public class IncompatibleService // the incompatible class we have
  {
    public string SpecificRequest() 
    {
      return "Req from incompatible service";
    }
  }

  public class Adapter : TargetService 
  {
    private readonly IncompatibleService _incompatibleService;

    public Adapter(IncompatibleService incompatibleService) 
    {
      _incompatibleService = incompatibleService;
    }

    // this implements the method the TargetService interface expects
    public string GetRequest() 
    {
      return _incompatibleService.SpecificRequest();
    }
  }
}

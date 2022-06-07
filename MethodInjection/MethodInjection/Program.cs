public interface IService
{
    void Serve();
}
public class Service1 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service1 Called");
    }
}
public class Service2 : IService
{
    public void Serve()
    {
        Console.WriteLine("Service2 Called");
    }
}
public class Client
{
    public IService service;
    public void ServeMethod(IService _service)
    {
        service = _service;
        service.Serve();
    }
}
class Program
{
    static void Main(string[] args)
    {
        //creating object
        Service1 s1 = new Service1();

        Client client = new Client();
        //client.Start(s1); //passing dependency
        //                  //TO DO:
        client.ServeMethod(s1);

        Service2 s2 = new Service2();
        //client.Start(s2); //passing dependency
        client.ServeMethod(s2);
    }
}
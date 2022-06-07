
public interface IHorn
{
    void Beep();
}
class Horn : IHorn {

    public void Beep() => Console.WriteLine("Beep...beep...beep");
}
class Car {
    private IHorn _horn;
    public Car(IHorn horn) //Constructor Injection
    {
        this._horn = horn;
    }

    //public IHorn Horn //Property Injection
    //{
    //    set { this._horn = value; }
    //}

    public IHorn horn;
    public void CarHorn(IHorn _horn) {
        horn = _horn;
        this._horn.Beep();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Horn h = new Horn();
        Car car = new Car(h);
        //car.Horn = h;
        car.CarHorn(h);
    }
}

public interface IHorn
{
    void Beep();
}
class Horn : IHorn {

    public void Beep() => Console.WriteLine("Beep...beep...beep");
}
//class Car {
//    private IHorn _horn;
//    public Car(IHorn horn) //Constructor Injection
//    {
//        this._horn = horn;
//    }

//    //public IHorn Horn //Property Injection
//    //{
//    //    set { this._horn = value; }
//    //}

//    public IHorn horn;
//    public void CarHorn(IHorn _horn) {
//        horn = _horn;
//        this._horn.Beep();
//    }
//}
// Contructor Injection
class CarCI 
{ 
    private IHorn _horn;
    public CarCI(IHorn horn) { 
        this._horn = horn;
    }
    public void CarHorn()
    {
        this._horn.Beep();
    }
}
// Method Injection
public class CarMI
{
    public IHorn horn;
    public void CarHorn(IHorn _horn)
    {
        horn = _horn;
        horn.Beep();
    }
}
// Property Injection
public class CarPI
{
    private IHorn _horn;
    public IHorn Horn
    {
        set { this._horn = value; }
    }
    public void CarHorn()
    {
        this._horn.Beep();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Horn h = new Horn();
        CarCI c1 = new CarCI(h);
        c1.CarHorn();


        CarMI c2 = new CarMI();
        c2.CarHorn(h);

        CarPI c3 = new CarPI();
        c3.Horn = h;
        c3.CarHorn();

    }
}
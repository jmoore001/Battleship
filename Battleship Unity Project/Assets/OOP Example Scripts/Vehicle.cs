public abstract class Vehicle
{
    // Encapsulation
    // The make and model of the vehicle are set when the vehicle is created, they cannot be changed after the vehicle is created (except by the Vehicle class).
    public string make { get; private set; }
    public string model { get; private set; }
    // The mileage of the vehicle is set to 0 when it is created. It can only be changed by using the AddMileage method, see below.
    public float mileage { get; private set; }

    public Vehicle(string make, string model)
    {
        this.make = make;
        this.model = model;
        this.mileage = 0;
    }

    protected void AddMileage(float amount)
    {
        mileage = mileage + amount;
    }

    // Abstraction
    // Every Vehicle can drive, but you may have to drive each vehicle differently
    public abstract void Drive();
}

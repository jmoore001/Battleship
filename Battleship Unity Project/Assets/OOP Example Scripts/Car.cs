using UnityEngine;

// Inheritance
// The Car class inherits the properties of the Vehicle class
// This means it can do everything that a Vehicle can
public class Car : Vehicle
{
    public bool HasAFlatTire { get; protected set; }

    public Car(string make, string model) : base(make, model)
    {
        HasAFlatTire = false;

        // These properties come from the Vehicle class
        Debug.Log($"Created a new car of make: {make} and model: {model}");
    }

    public override void Drive()
    {
        if (HasAFlatTire)
        {
            Debug.LogError($"Car of make: {make} and model: {model} got a flat tire at mileage: {mileage}");
            return;
        }

        PushGasPedal();
        AddMileage(10);
        PushBrakePedal();

        HasAFlatTire = true;
    }

    void PushGasPedal()
    {
        Debug.Log($"{make} {model} pressed the gas pedal.");
    }

    void PushBrakePedal()
    {
        Debug.Log($"{make} {model} pressed the brake pedal.");
    }
}

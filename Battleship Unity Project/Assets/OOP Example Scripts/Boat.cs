using UnityEngine;

// Inheritance
// The Boat class inherits the properties of the Vehicle class
// This means it can do everything that a Vehicle can
public class Boat : Vehicle
{
    public bool IsFloating { get; protected set; }

    public Boat(string make, string model) : base(make, model)
    {
        IsFloating = true;

        // These properties come from the Vehicle class
        Debug.Log($"Created a new boat of make: {make} and model: {model}");
    }

    public override void Drive()
    {
        if (IsFloating == false)
        {
            Debug.LogError($"Boat of make: {make} and model: {model} is not floating and has mileage: {mileage}");
            return;
        }

        PushSpeedLeverForward();
        AddMileage(2);
        PullSpeedLeverBackwards();

        IsFloating = false;
    }

    void PushSpeedLeverForward()
    {
        Debug.Log($"{make} {model} pressed the speed lever forward.");
    }

    void PullSpeedLeverBackwards()
    {
        Debug.Log($"{make} {model} pulled the speed lever backwards.");
    }
}

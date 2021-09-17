using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    List<Vehicle> vehicles;

    void Start()
    {
        vehicles = new List<Vehicle>();
        vehicles.Add(new Car(make: "Toyota", model: "Tacoma"));
        vehicles.Add(new Boat(make: "Seadoo", model: "Spark"));

        // Polymorphism
        // Both cars and boats use a Drive method to move, but they function differently
        //
        // Cars use gas and brake pedals
        // Boats use a speed lever
        foreach (Vehicle vehicle in vehicles)
        {
            // Attempts to drive each vehicle twice, the second time may throw an error
            vehicle.Drive();
            vehicle.Drive();
        }
    }
}

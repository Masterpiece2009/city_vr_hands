using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public List<GameObject> cars; // List of car prefabs
    public int carAmount; // Total number of cars to spawn
    public int numSpawned; // Counter for cars spawned

    // Start is called before the first frame update
    void Start()
    {
        carAmount = 3; // Number of cars to spawn

        // Loop to instantiate cars
        for (int i = 0; i < carAmount; i++)
        {
            int carType = Random.Range(0, cars.Count); // Pick a random car type from the list
            Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), -5, Random.Range(-5, 5)); // Random spawn position with Y set to -5
            Instantiate(cars[carType], spawnPosition, Quaternion.identity); // Instantiate the car at the spawn position
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Additional logic can go here (if needed)
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerSpawner : MonoBehaviour
{
    public GameObject passenger_GO;

    private float line_space=0;

    public List<GameObject> spawnedPassengers;

    private int passengerCount;

    public int PassengerCount { get => passengerCount; set => passengerCount = value; }

    private void Start()
    {
        StartCoroutine(PassengerSpawnerStart());
    }


    private IEnumerator PassengerSpawnerStart() {
        
        if(passengerCount<10)
        PassengerSpawn();
        yield return new WaitForSeconds(2);
        StartCoroutine(PassengerSpawnerStart());
    }

    private void PassengerSpawn()
    {
        var passenger = Instantiate(passenger_GO);
        passenger.transform.position = transform.position+ new Vector3(0,1,line_space);
        spawnedPassengers.Add(passenger);
        line_space += 2.5f;
        passengerCount++;
        if (passengerCount > 9)
            line_space = 0;
    }

    

}

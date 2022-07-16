using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPassengers : MonoBehaviour
{

    public List<GameObject> collectedPassengers;

    private bool oneTime=true;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("SpawnPlace"))
        {
            if (oneTime == true)
            {
                oneTime = false;
                // TODO : Collect passenger
                
            }
        }
    }


    private IEnumerator PassengersGoesToCar(GameObject spawnPoint)
    {
        float elapsedTime = 0;
        
        while (elapsedTime < 2f)
        {
            var progress = Mathf.Clamp01(elapsedTime);
            elapsedTime += Time.deltaTime;
        }
        yield return null;

    }



    private IEnumerator CollectingPassenger(GameObject spawnPoint)
    {
        //collectedPassengers.Add(spawnPoint.GetComponent<PassengerSpawner>().spawnedPassengers[0]);
        //spawnPoint.GetComponent<PassengerSpawner>().spawnedPassengers.RemoveAt(0);
        yield return null;
    }


}

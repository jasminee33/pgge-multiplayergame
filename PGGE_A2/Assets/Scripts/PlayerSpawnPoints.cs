using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoints : MonoBehaviour
{
    //Q1-Encapsulating
    //referencing: https://procodeguide.com/programming/oop-concept-encapsulation-in-c-net/\

    //private to prevent user to have direct access
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();

    //player can interact with the spawn points
    public Transform GetSpawnPoint()
    {
        if (spawnPoints.Count == 0)
        {
            return transform;
        }

        return GetRandomSpawnPoint();
    }

    //private to not allow player to change and control access
    private Transform GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);
        return spawnPoints[randomIndex];
    }
}
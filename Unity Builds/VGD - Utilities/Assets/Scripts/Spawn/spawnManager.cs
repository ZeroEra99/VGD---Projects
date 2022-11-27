using System;
using UnityEngine;

/*
 * Manages the spawn in the game.
 */

public class spawnManager : MonoBehaviour
{

    [SerializeField] private BodyMovement _body;
    [SerializeField] public Transform defaultSpawnPoint;
    public Transform respawnPoint;

    private void Awake()
    {
        _body = FindObjectOfType<BodyMovement>();
        SetSpawnPoint(defaultSpawnPoint);
    }

    //This is used inside the checkPoint.cs script to modify the local respawnPoint variable.
    public void SetSpawnPoint(Transform respawnPointUpdated)
    {
        respawnPoint = respawnPointUpdated;
    }
    public void Spawn(Transform spawnPoint)
    {
        //Moves the character to the spawn Point
        _body.transform.position = spawnPoint.position;
        //alligns the character with the spawn point orientation
        _body.transform.rotation = spawnPoint.rotation;
        Physics.SyncTransforms();
    }
}

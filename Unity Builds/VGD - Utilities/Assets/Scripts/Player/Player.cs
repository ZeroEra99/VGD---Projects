using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private BodyMovement _bodyMovement;
    [SerializeField] private spawnManager _spawnManager;
    void Start()
    {
        _spawnManager = FindObjectOfType<spawnManager>();   //Automatically attaches to the spawnManager
        _bodyMovement = FindObjectOfType<BodyMovement>();
        _spawnManager.Spawn(_spawnManager.defaultSpawnPoint);  //-> This makes the game crash on launch.
    }
    private void Update()
    {
        _bodyMovement.move();
        if (Input.GetKeyDown(KeyCode.T)) _spawnManager.Spawn(_spawnManager.respawnPoint); //Respawn the character when pressing T
    }
}
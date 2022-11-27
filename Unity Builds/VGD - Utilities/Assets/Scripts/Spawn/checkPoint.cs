    using UnityEngine;

/*
 * To be applied to checkpoint objects.
 */
public class checkPoint : MonoBehaviour
{
    //Needed to acces the spawnManager script and modify its spawnPoint from here.
    public spawnManager _SpawnManager;
    private void Start()
    {
        //This finds the spawnManager script automatically, so it is not needed to assign it from the editor.
        _SpawnManager = FindObjectOfType<spawnManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //This modifies the spawnPoint.
            _SpawnManager.SetSpawnPoint(transform);
            //This disables the checkPoint after it's been reached.
            GetComponent<Collider>().enabled = false;
        }
    }
}

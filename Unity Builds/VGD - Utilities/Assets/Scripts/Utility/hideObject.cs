using UnityEngine;

/*
 * Makes the object disappear while the game is running.
 */

public class hideObject : MonoBehaviour
{
    //The object that needs to disappear
    [SerializeField] GameObject objectToHide;
    private void Awake()
    {
        //goodbye mf
        objectToHide.SetActive(false);
    }
}

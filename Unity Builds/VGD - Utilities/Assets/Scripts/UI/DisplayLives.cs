using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayLives : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "Lives:\n" + PlayerStats.currentLives.ToString();
    }
}

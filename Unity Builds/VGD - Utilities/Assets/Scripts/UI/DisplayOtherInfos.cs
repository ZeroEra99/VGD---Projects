using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayOtherInfos : MonoBehaviour
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
        /*
         For this to work the variable has to be assigned first
         */
        textMesh.text = "Last checkpoint:\n";
        // textMesh.text = "Last checkpoint:\n" + PlayerStats.LastCheckpoint.ToString();
    }
}

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
        textMesh.text = "Last checkpoint:\n" + PlayerStats.LastCheckpoint.ToString();
    }
}

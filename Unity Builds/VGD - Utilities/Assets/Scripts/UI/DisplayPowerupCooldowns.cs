using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPowerupCooldowns : MonoBehaviour
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
        string displayString = "Powerup Cooldowns:\n";
        foreach (KeyValuePair<KeyCode, int> powerupCooldown in PlayerStats.currentPowerupCooldown)
        {
            displayString += powerupCooldown.Key.ToString() + ": " + powerupCooldown.Value.ToString() + "\n";
        }
        textMesh.text = displayString;
    }
}

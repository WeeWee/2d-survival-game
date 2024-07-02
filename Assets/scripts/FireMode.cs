using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireMode : MonoBehaviour
{
    public static bool FireModeBool = false;
    public static bool ShotgunBool = false;
    Text FireModeText;
    // Start is called before the first frame update
    void Start()
    {
        FireModeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FireModeBool == false)
        {
            FireModeText.text = "Firemode: single";
        }
        if (FireModeBool == true)
        {
            FireModeText.text = "Firemode: Automatic";
        }
        if (ShotgunBool == true)
        {
            FireModeText.text = "Firemode: shotgun";
        }
        if (ShotgunBool == false && FireModeBool == true)
        {
            FireModeText.text = "Firemode: Automatic";
        }
        if (ShotgunBool == false && FireModeBool == false)
        {
            FireModeText.text = "Firemode: single";
        }
    }
}

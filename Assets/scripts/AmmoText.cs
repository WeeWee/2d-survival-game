using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    public static int Ammo;
    Text ammoText;
    // Start is called before the first frame update
    void Start()
    {
        ammoText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Ammo = AmmoPackScript.currentammo;
        ammoText.text = "Ammo: " + Ammo;
    }
}

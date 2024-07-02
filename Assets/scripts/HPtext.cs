using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPtext : MonoBehaviour
{
    Text Hptext;
    // Start is called before the first frame update
    void Start()
    {
        Hptext= GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.Health < PlayerHealth.MaxHealth)
        {
            Hptext.text = PlayerHealth.Health + " HP";
        }
        if (PlayerHealth.Health >= PlayerHealth.MaxHealth)
        {
            Hptext.text = "FULL HP";
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBalance : MonoBehaviour
{
    public static float playerBalance;
    public float Timer;
    public int ResetTime = 0;
    Text BalanceText;
    // Start is called before the first frame update
    void Start()
    {
        BalanceText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Timer += Time.deltaTime;
        BalanceText.text = playerBalance + " $";
        if (Timer > 5 || Timer == 5)
        {
            playerBalance += 5;
            Timer = ResetTime;
        }
    }
    
}

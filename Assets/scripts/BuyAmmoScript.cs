using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyAmmoScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickAmmo()
    {
        if (PlayerBalance.playerBalance > 100 || PlayerBalance.playerBalance == 100)
        {
            PlayerBalance.playerBalance -= 100;
            AmmoPackScript.currentammo += 50;
        }
    }
    public void OnClickHp()
    {
        if (PlayerBalance.playerBalance > 200)
        {
            PlayerBalance.playerBalance -= 200;
            PlayerHealth.Health = PlayerHealth.MaxHealth;
        }
    }
    
}

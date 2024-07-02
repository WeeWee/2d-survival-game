using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void FullHealth()
    {
        if (PlayerBalance.playerBalance > 20 || PlayerBalance.playerBalance == 20)
        {
            PlayerBalance.playerBalance = PlayerBalance.playerBalance - 20;
            PlayerHealth.Health = 40;
        }
        
    }
    public void Exit()
    {
        SceneManager.LoadScene("level1");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

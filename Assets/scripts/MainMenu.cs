using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void Update()
    {
        PlayerHealth.Health = PlayerHealth.StarterHealth;
        PlayerBalance.playerBalance = 0;
        AmmoPackScript.currentammo = 20;
        if (PlayerHealth.Health == 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathMenu");
        }
    }
    public void StartButton()
    {
        SceneManager.LoadScene("level1");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}

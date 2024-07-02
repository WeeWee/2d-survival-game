using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
        PlayerHealth.Health = 40;
        PlayerBalance.playerBalance = 0;
        AmmoPackScript.currentammo = 20;
        if (PlayerHealth.Health == 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathMenu");
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

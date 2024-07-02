using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class loader : MonoBehaviour
{
    public Text ProgressText;
    public GameObject SceneLoader;
    public Slider slider;
    public float timer;
    public GameObject Continue;
    public int maxTime;
    private void Start()
    {
        StartCoroutine(LoadAsync());
    }
    public void Loader()
    {
        
    }
    private void Update()
    {
        
        
    }
    IEnumerator LoadAsync ()
    {
        SceneLoader.SetActive(true);
        while (timer < maxTime)
        {

            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / 10);
            slider.value = progress;
            yield return new WaitForSeconds (0.001f);
            
        }
        if (timer > maxTime || timer == maxTime)
        {
            Continue.SetActive(true);
        }

    }
    public void ContinueButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int StarterHealth = 40;
    public static int Health;
    public static int MaxHealth = 40;
    public int test;
    public int currenthealth;
    RectTransform rectTransform;
    Image healthbar;
    // Start is called before the first frame update
    void Start()
    {
        Health = StarterHealth;
        currenthealth = Health;
        healthbar = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float HealthProcentage = Health/(float)currenthealth;
        rectTransform.localScale = new Vector3(HealthProcentage, 1, 1);
    }
}

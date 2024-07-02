using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPackScript : MonoBehaviour
{
    public int ammo;
    public  static int currentammo;
    public int minammodrop;
    public int maxammodrop;
    // Start is called before the first frame update
    void Start()
    {
        currentammo = currentammo + ammo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            currentammo += Random.Range(minammodrop, maxammodrop);
        }
    }
}
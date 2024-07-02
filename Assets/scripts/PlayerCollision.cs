using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    public GameObject Ammo;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.Health == 0f || PlayerHealth.Health < 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("DeathMenu");
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Zombie")
        {
            
            PlayerHealth.Health = PlayerHealth.Health - 5;
            
        }
        if (collision.collider.tag == "ZombieBoss")
        {
            PlayerHealth.Health = PlayerHealth.Health - 2;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Zombie")
        {

            PlayerHealth.Health = PlayerHealth.Health - 2;

        }
        if (collision.collider.tag == "ZombieBoss")
        {
            PlayerHealth.Health = PlayerHealth.Health - 1;
        }
    }

}

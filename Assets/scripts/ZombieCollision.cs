using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCollision : MonoBehaviour
{
    public float playerbalance;
    public float ZombieHealth = 40f;
    public GameObject Ammo;
    ParticleSystem particleSystem;
    
   
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GameObject.FindGameObjectWithTag("Blood").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ZombieHealth <= 0f)
        {
            Destroy(gameObject);
            SpawnAmmo();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "bullet")
        {
            PlayerBalance.playerBalance = PlayerBalance.playerBalance + 2;
            ZombieHealth = ZombieHealth - 5f;
            SpawnBlood();
        }
    }

    void SpawnAmmo()
    {
        GameObject ammo = Instantiate(Ammo, transform.position, Quaternion.identity) as GameObject;
    }
     void SpawnBlood()
    {
        particleSystem.transform.position = transform.position;
        particleSystem.Play();
    }
    
}

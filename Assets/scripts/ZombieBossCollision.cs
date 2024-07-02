using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBossCollision : MonoBehaviour
{
   
    public float ZombieHealth = 60f;
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
           PlayerBalance.playerBalance = PlayerBalance.playerBalance + 3;
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
        Instantiate(particleSystem.gameObject, transform.position,Quaternion.identity);
        Destroy(particleSystem.gameObject, 2);
    }
}

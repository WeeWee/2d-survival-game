using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieBossWave : MonoBehaviour
{
    public GameObject ZombiePrefab;
    public float minx;
    public float maxx;
    public float miny;
    public float maxy;
    public float respawntime;
    public int zombieatm = 1;
    public int maxzombiespawn = 5;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Zombiewave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnZombies()
    {
        Vector2 newPosition = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
        GameObject a = Instantiate(ZombiePrefab) as GameObject;

        while (Vector2.Distance(Player.transform.position, newPosition) < 5)
        {
            newPosition = new Vector2(Random.Range(minx, maxx), Random.Range(miny, maxy));
        }
        a.transform.position = newPosition;
    }
    IEnumerator Zombiewave()
    {
        while (zombieatm < maxzombiespawn)
        {
            yield return new WaitForSeconds(respawntime);
            SpawnZombies();
            /*if (zombieatm == 0 || Input.GetKey(KeyCode.Escape))
            {
                SceneManager.LoadScene("Shop");
            }*/
 
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public float timer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
       
    }
    
}

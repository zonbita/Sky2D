﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour {

    [Tooltip("Damage")]
    public int damage;

    [Tooltip("projectile")]
    public bool enemyBullet;

    [Tooltip("collision")]
    public bool destroyedByCollision;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (enemyBullet && collision.tag == "Player") 
        {
            Player.instance.GetDamage(damage); 
            if (destroyedByCollision)
                Destruction();
        }
        else if (!enemyBullet && collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().GetDamage(damage);
            if (destroyedByCollision)
                Destruction();
        }
    }

    void Destruction() 
    {
        Destroy(gameObject);
    }
}



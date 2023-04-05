using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    public float lifetime = 2f;
    public int damage = 10;
    Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Destroy(gameObject, lifetime);
    }
   

    void OnCollisionEnter2D(Collision2D collision)
    {

        HealthEnemy Pv = collision.gameObject.GetComponent<HealthEnemy>();

        if (Pv != null)
        {
            Pv.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}

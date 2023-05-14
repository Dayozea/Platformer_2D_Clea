using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balle : MonoBehaviour
{
    public float lifetime = 2f;
    public int damage = 10;
    Rigidbody2D rb;
    private bool Obstacle;
    public LayerMask Obstacle_Layer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Destroy(gameObject, lifetime);
    }

    private void Update()
    {
        Obstacle = Physics2D.OverlapCircle(transform.position, 1f, Obstacle_Layer);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        HealthEnemy Pv = collision.gameObject.GetComponent<HealthEnemy>();
        if (Pv != null)
        {
            Pv.TakeDamage(damage);
        }
        //if (collision.gameObject.layer == Obstacle_Layer)
        //{
            Destroy(gameObject);
        //}
           

        
    }
}

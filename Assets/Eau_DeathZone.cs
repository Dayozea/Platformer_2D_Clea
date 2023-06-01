using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eau_DeathZone : MonoBehaviour
{
    [SerializeField] private int Degat_Eau;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("rrr");
            collision.gameObject.GetComponent<playerHealth>().TakeDamage(Degat_Eau);
        }
    }
}

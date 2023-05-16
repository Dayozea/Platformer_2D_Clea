using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eau_DeathZone : MonoBehaviour
{
    [SerializeField] private int Degat_Eau;
    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player")==true)
        {
            player.GetComponent<playerHealth>().TakeDamage(Degat_Eau);
        }
    }
}

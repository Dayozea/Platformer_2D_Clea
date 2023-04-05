using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    private int Damage;
    private int MaxHealth=100;
    bool IsDead = false;

    [SerializeField] public int CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            IsDead = true;
        }
        if (IsDead==true)
        {
            Destroy(gameObject);
            Debug.Log(name + " Detruit");
        }
    }
    public void TakeDamage(int Damage)
    {
        CurrentHealth = CurrentHealth - Damage;
        Debug.Log( name + " est Touché");
    }
}

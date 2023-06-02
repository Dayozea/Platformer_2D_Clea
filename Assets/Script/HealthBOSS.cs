using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBOSS : MonoBehaviour
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("PanPan");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

    public void TakeDamage(int Damage)
    {
        CurrentHealth = CurrentHealth - Damage;
        Debug.Log( name + " est Touché");
    }
}

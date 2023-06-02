using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//public class Gun : MonoBehaviour
//{
//    public Transform firePoint; 
//    public GameObject bulletPrefab; 

//    void Update()
//    {
//        if (Input.GetButtonDown("Fire1"))
//        {
//            Shoot();
//        }
//    }

//    void Shoot()
//    {
//        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
//    }
//}

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform shootingPoint; // Mettre sur Unity là ou le projectile va spawn 
    [SerializeField] private GameObject bulletPrefab; // Mettre sur Unity l'objet qu'on va faire spawn(donc notre projectile)
    [SerializeField] private float FireRate = 15f;
    [SerializeField] private float speed = 5; // Vitesse du projectile
    
    [SerializeField]private SpriteRenderer sr; //SpriteRenderer du GameObject  
    private float nextTimeToFire = 0;

    Animator Anim;


    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire) // Si on appuie sur le bouton ("Fire1") 
        {
            nextTimeToFire = Time.time + 1f /FireRate;
            StartCoroutine(shoot()); //on lance shoot()
            Debug.Log("ff");

        }


    }
    private IEnumerator shoot()
    {
        Anim.SetBool("shoot", true);
        

        if (sr.flipX == true) // On verifie si le SpriteRenderer de l'object qu'on a renseigner avant a flip sur x si oui: 
            {
                GameObject go = Instantiate(bulletPrefab, shootingPoint.position, transform.rotation); //on spawn un projectile au shooting.position et tourne comme le transform.rotation 
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0); //On fais maintenant bouger l'object par rapport a la speed qu'on a mis avant 
            }
            else
            {
                GameObject go = Instantiate(bulletPrefab, shootingPoint.position, transform.rotation); // Meme chose que l'autre
                go.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0); //Meme chose mais va de l'autre sens
            }
        yield return new WaitForSecondsRealtime(0.3f);
        Anim.SetBool("shoot", false);
    }
    

    
}

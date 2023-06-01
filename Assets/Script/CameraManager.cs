using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject playerRef;
    Vector3 refVelocity = Vector3.zero;
    float smoothTime = 0.2f;
    [SerializeField] SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.flipX == false)
        {
            Vector3 targetPosition = new Vector3(playerRef.transform.position.x + 5, playerRef.transform.position.y, -10);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);


        }
        if (sr.flipX == true)
        {
            Vector3 targetPosition = new Vector3(playerRef.transform.position.x - 5, playerRef.transform.position.y, -10);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);


        }
    }
}

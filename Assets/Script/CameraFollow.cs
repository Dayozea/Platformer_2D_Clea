using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target; // le joueur à suivre

    void Update()
    {
        // calcule la position souhaite de la camera
        Vector3 desiredPosition = target.position;

        // definit la nouvelle position de la camera
        transform.position = desiredPosition;
    }
}


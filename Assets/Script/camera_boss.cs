using UnityEngine;
using System.Collections;
using UnityEditor.U2D.Animation;

public class camera_boss : MonoBehaviour
{

    public Camera Main_Camera;
    void Start()
    {
        GetComponent<Camera>().enabled = false;
        //camera.GetComponent<camera_boss>().enabled = false;
        // camera.GetComponent<CameraManager>().enabled = true;  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            ActiveBossCamera();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        DeactiveBossCamera();
    }
    public void ActiveBossCamera()
    {
        GetComponent<Camera>().enabled = true;
        Main_Camera.enabled = false;
    }

    public void DeactiveBossCamera()
    {
        GetComponent<Camera>().enabled = false;
        Main_Camera.enabled = true;
    }
}
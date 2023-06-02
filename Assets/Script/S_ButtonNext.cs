using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_ButtonNext : MonoBehaviour
{
    [SerializeField] private string[] ListDialogue;
    [SerializeField] private Text txt;
    [SerializeField] private bool End = false;

     private int i = 0;

    private void Start()
    {
        txt.text = ListDialogue[i];
    }
    public void ChangeText()
    {
        if(i - 3 >= ListDialogue.Length)
        {
            if (End == false)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }else
            {
                Application.Quit();
            }
        }else
        {
            i++;
        }

        txt.text = ListDialogue[i];
    }

}

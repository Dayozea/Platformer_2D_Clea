using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pv_pourcentage : MonoBehaviour
{
    static Text Txt;
    [SerializeField] HealthBar health;

    // Start is called before the first frame update
    void Start()
    {
        Txt = GetComponent<Text>();
    }

    private void Update()
    {
        Txt.text = health.slider.value + " %";
    }
}

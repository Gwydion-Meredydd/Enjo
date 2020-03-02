using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelMGR : MonoBehaviour
{
    [Header("Enabling Panels")]
    public GameObject panelDisable;
    public GameObject panelEnable;
 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panelDisable.SetActive(false);
            Debug.Log("Panel disabled!");
        }

        if (Input.GetMouseButtonDown(0))
        {
            panelEnable.SetActive(true);
            Debug.Log("Panel Enabled!");
        }
    }
}



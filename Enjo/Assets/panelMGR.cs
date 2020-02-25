using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelMGR : MonoBehaviour
{
    public GameObject panelDisable;
    public GameObject panelEnable;
   

    void Update()
    {
      if  (Input.GetKeyDown(KeyCode.Space))
        {
            panelDisable.SetActive(false);
            Debug.Log("Panel disabled!");
        }

      if (Input.GetKeyDown(KeyCode.Space))
        {
            panelEnable.SetActive(true);
            Debug.Log("Panel Enabled!");
        }
    }
}

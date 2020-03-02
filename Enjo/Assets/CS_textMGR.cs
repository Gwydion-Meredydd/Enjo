using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS_textMGR : MonoBehaviour
{

    [Header("Enabling Text")]
    public GameObject textDisable;
    public GameObject textEnable;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textDisable.SetActive(false);
            Debug.Log("Text disabled!");
        }

        if (Input.GetMouseButtonDown(0))
        {
            textEnable.SetActive(true);
            Debug.Log("Text Enabled!");
        }
    }
}

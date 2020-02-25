using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_textMGR : MonoBehaviour
{

    [Header("Enabling Text")]
    public GameObject textDisable;
    public GameObject textEnable;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textDisable.SetActive(false);
            Debug.Log("Text disabled!");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            textEnable.SetActive(true);
            Debug.Log("Text Enabled!");
        }
    }
}

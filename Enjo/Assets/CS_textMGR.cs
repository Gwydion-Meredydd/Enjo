using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS_textMGR : MonoBehaviour
{

    [Header("Enabling Text")]
    public GameObject textDisable;
    public GameObject textEnable;
    public Animator fadeAnim;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Text Enabled!");
            fadeAnim.SetBool("Fade", true);
            StartCoroutine(Timing());
        }
    }
    IEnumerator Timing()
    {
        yield return new WaitForSeconds(0.5f);
        textEnable.SetActive(true);
        textDisable.SetActive(false);
    }
}

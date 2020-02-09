using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Subtitles : MonoBehaviour
{
    public GameObject textBox;
    void Start()
    {
        StartCoroutine(subSequence());
    }

    IEnumerator subSequence()
    {
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "Oh no! I fell asleep again!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Dad is going to kill me...I promised him I would go to the market.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Wait, where are all of my things?!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "I must have left them around here somewhere...";

    }
}

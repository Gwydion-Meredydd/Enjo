using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelMGR : MonoBehaviour
{
    public float clicking;

    [Header("Boards")]
    public GameObject boardOne;
    public GameObject boardTwo;
    public GameObject boardThree;
    public GameObject boardFour;
    public GameObject boardFive;
    public GameObject boardSix;
    public GameObject boardSeven;
    public GameObject boardEight;
    public GameObject boardNine;
    public GameObject boardTen;
    public GameObject boardEleven;
    public GameObject boardTwelve;
    public Animator fadeAnim;

    void Start()
    {
        clicking = 1;
        ClickMethod();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ClickMethod();
            fadeAnim.SetBool("Fade", true);

        }
    }
    public void ClickMethod()
    {
        if (clicking == 1)
        {
            boardOne.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 2)
        {
            boardOne.SetActive(false);

            boardTwo.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 3)
        {
            boardThree.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 4)
        {
            boardFour.SetActive(true);
            clicking = clicking + 1;
            Debug.Log(clicking);

        }

        else if (clicking == 5)
        {
            boardFive.SetActive(true);

            boardTwo.SetActive(false);
            boardThree.SetActive(false);
            boardFour.SetActive(false);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 6)
        {
            boardFive.SetActive(false);

            boardSix.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 7)
        {
            boardSeven.SetActive(true);

            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 8)
        {
            boardSix.SetActive(false);
            boardSeven.SetActive(false);

            boardEight.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 9)
        {
            boardEight.SetActive(false);

            boardNine.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 10)
        {
            boardTen.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 11)
        {
            boardNine.SetActive(false);
            boardTen.SetActive(false);

            boardEleven.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }

        else if (clicking == 12)
        {
            boardEleven.SetActive(false);

            boardTwelve.SetActive(true);
            clicking = clicking + 1;

            Debug.Log(clicking);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelMGRTest : MonoBehaviour
{
    public float clicking = 1;

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

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(clicking == 1)
            {
                boardOne.SetActive(true);
                clicking = clicking + 1;
            }

            else if(clicking == 2)
            {
                boardOne.SetActive(false);
                boardTwo.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 3)
            {
                boardThree.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 4)
            {
                boardFour.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 5)
            {
                boardFive.SetActive(true);

                boardTwo.SetActive(false);
                boardThree.SetActive(false);
                boardFour.SetActive(false);
                clicking = clicking + 1;
            }

            else if (clicking == 6)
            {
                boardFive.SetActive(false);
                boardSix.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 7)
            {
                boardSeven.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 8)
            {
                boardSix.SetActive(false);
                boardSeven.SetActive(false);
                boardEight.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 9)
            {
                boardEight.SetActive(false);
                boardNine.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 10)
            {
                boardTen.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 11)
            {
                boardNine.SetActive(false);
                boardTen.SetActive(false);
                boardEleven.SetActive(true);
                clicking = clicking + 1;
            }

            else if (clicking == 12)
            {
                boardEleven.SetActive(false);
                boardTwelve.SetActive(true);
                clicking = clicking + 1;
            }
        }
    }
}

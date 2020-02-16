using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class QuestsController : MonoBehaviour
{
    public int PickUpAmmount;
    public int HasPickedUpAmmount;

    public int QuestNumber;
    public QuestList QuestList = new QuestList();
    public int pickedupammount;

    public void Start()
    {
        NewQuest();
    }
    public void NewQuest()
    {
        QuestNumber++;
    }
    public void pickup()
    {
        if (pickedupammount < 3)
        {
            pickedupammount++;
        }
        if (pickedupammount == 3) 
        {
            pickedupammount = 0;
            NewQuest();
        }
    }

}
[System.Serializable]
public class Quests
{
    public string Name;
    public List<GameObject> QuestItems;
}

[System.Serializable]
public class QuestList
{
    public List<Quests> Quests;
}


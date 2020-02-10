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

    public void Start()
    {
        NewQuest();
    }
    public void NewQuest()
    {
        for (int i = 0; i < QuestList.Length; i++)
        {

        }
        QuestNumber++;
    }
    public void pickup()
    {

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


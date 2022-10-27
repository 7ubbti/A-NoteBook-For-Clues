using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace SweetCandy.MisTrust
{
    public class AddClue : MonoBehaviour
    {
        public Text text;
        [SerializeField]
        public Clue.Type t;

        public GameObject MessageReceiver;
        public GameObject clueController;
        public GameObject HomeReceiver;
        public void Click()
        {
            if (!Clue.OwnedClues.Exists(clues => clues.Key == Clue.showingClue.Key))
            {
                Clue.OwnedClues.Add(new Clue.clue { Key = Clue.showingClue.Key, text = Clue.showingClue.text, Type = t });
                Clue.ClueArray.Remove(Clue.showingClue.Key);
                MessageReceiver.SendMessage("add", t);
                HomeReceiver.SendMessage("add", t);
                clueController.SendMessage("displayaddClue");

            }
            else
            {
                GameObject[] label = GameObject.FindGameObjectsWithTag("label");
                foreach (var obj in label)
                {
                    if (obj.GetComponent<SaveLabel>().Key == Clue.showingClue.Key
                    && obj.GetComponent<SaveLabel>().type == Clue.showingClue.Type)
                    {
                        Destroy(obj);
                    }
                }
                Clue.OwnedClues.Find(cl => cl.Key == Clue.showingClue.Key).Type = t;
                Debug.Log(Clue.OwnedClues.Count); //测试此时OwnedClues的容量
                MessageReceiver.SendMessage("add", t);
                HomeReceiver.SendMessage("add", t);
                clueController.SendMessage("displayaddClue");
            }

        }
    }
}
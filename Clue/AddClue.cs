using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 点击3种类型按钮后进行添加Clue的处理
/// </summary>
namespace SweetCandy.MisTrust
{
    public class AddClue : MonoBehaviour
    {
        [SerializeField] protected Clue.Type t;

        public GameObject MessageReceiver; //用来添加当页的标签的对象
        public GameObject clueController; //用来处理Clue传递的对象
        public GameObject HomeReceiver; //用来添加主页的标签的对象
        public void Click()
        {
            if (!Clue.OwnedClues.Exists(clues => clues.Key == Clue.showingClue.Key)) //新线索
            {
                Clue.OwnedClues.Add(new Clue.clue { Key = Clue.showingClue.Key, text = Clue.showingClue.text, Type = t });
                Clue.ClueArray.Remove(Clue.showingClue.Key);
                MessageReceiver.SendMessage("add", t);
                HomeReceiver.SendMessage("add", t);
                clueController.SendMessage("displayaddClue");

            }
            else //旧线索
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
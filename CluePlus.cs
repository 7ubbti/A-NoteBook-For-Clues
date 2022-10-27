using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// 给玩家添加Clue
/// </summary>
namespace SweetCandy.MisTrust
{
    public class CluePlus : MonoBehaviour
    {
        public GameObject clueController; //线索控制对象
        public void Clueplus(string cluetag) //一般放在GameManager中 来调用给玩家添加线索
        {
            int c = System.Convert.ToInt32(cluetag);
            //Debug.Log(Clue.OwnedClues.Exists(cl => cl.Key == c));
            if (!Clue.OwnedClues.Exists(cl => cl.Key == c))
            {
                Clue.ClueArray.Add(c, Clue.TotalClueArray[c]);
                Debug.Log(Clue.ClueArray.ContainsKey(c));
                clueController.SendMessage("displayClue", c);
            }
        }
    }
}
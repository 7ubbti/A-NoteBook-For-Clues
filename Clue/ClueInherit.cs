using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 线索的跨场景继承
/// </summary>
namespace SweetCandy.MisTrust
{
    public class ClueInherit : MonoBehaviour
    {
        public GameObject MessageReceiver; //同AddClue
        public GameObject HomeReceiver;
        public GameObject Bookpanel;
        private bool isEditor = false;
        void Start()
        {
            //Debug.Log("ClueArray.Count =" + Clue.ClueArray.Count);
            Bookpanel.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
            MessageReceiver.BroadcastMessage("addOld", Clue.OwnedClues.Count - 1);
            HomeReceiver.SendMessage("addOld", Clue.OwnedClues.Count - 1);
        }
    }
}
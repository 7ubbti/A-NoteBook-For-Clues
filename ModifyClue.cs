using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SweetCandy.MisTrust
{
    public class ModifyClue : MonoBehaviour
    {
        public Text RightText;
        // private GameObject Label;
        private Text LabelText;
        public GameObject OperationInterface;
        public GameObject EmptyText;
        private void Start()
        {
            LabelText = gameObject.GetComponentInChildren<Text>();
        }
        public void displayClue()
        {

            OperationInterface.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
            EmptyText.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
            RightText.text = LabelText.text;
            Clue.showingClue.text = LabelText.text;
            Clue.showingClue.Key = gameObject.GetComponent<SaveLabel>().Key;
            Clue.showingClue.Type = gameObject.GetComponent<SaveLabel>().type;

        }
        public void destroySelf()
        {
            Destroy(this);
        }


    }
}
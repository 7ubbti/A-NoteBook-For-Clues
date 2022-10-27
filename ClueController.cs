using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Linq;

namespace SweetCandy.MisTrust
{
    public class ClueController : MonoBehaviour
    {
        public Text text;
        public GameObject OperationInterface;//即一个text框和三个按钮
        public GameObject EmptyText;
        public GameObject Notebook;
        public static bool flag = false;
        public void displayClue(int cluetag)
        {
            if (flag == true || cluetag == 0)
            {
                Notebook.SendMessage("generateRedDot");
                OperationInterface.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
                EmptyText.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
                Clue.showingClue.Key = cluetag;
                Clue.showingClue.text = Clue.TotalClueArray[cluetag];
                text.text = Clue.showingClue.text;
                flag = false;
            }
        }
        public void displayaddClue()
        {
            if (Clue.ClueArray.Count > 0)
            {
                Notebook.SendMessage("generateRedDot");
                OperationInterface.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
                EmptyText.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
                var c = Clue.ClueArray.First();
                Clue.showingClue.Key = c.Key;
                Clue.showingClue.text = c.Value;
                text.text = Clue.showingClue.text;
                flag = false;
            }
            else
            {
                OperationInterface.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
                EmptyText.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
                flag = true;
            }
        }
    }
}

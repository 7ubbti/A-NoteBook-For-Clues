using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Linq;
/// <summary>
/// 线索类型控制
/// </summary>
namespace SweetCandy.MisTrust
{
    public class ClueController : MonoBehaviour
    {
        public Text text; //显示线索内容
        public GameObject OperationInterface;//即一个text框和三个按钮的界面
        public GameObject EmptyText; //默认无线索时的空底板
        public GameObject Notebook; //书本对象
        public static bool flag = false; //判断此时是否有线索展示
        public void displayClue(int cluetag) //展示添加的新线索 
        {
            if (flag == true || cluetag == 0) //如果此时有线索展示 将不显示
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
        public void displayaddClue() //展示后续的线索
        {
            if (Clue.ClueArray.Count > 0) //还有线索剩余时继续展示
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
            else //否则显示为空
            {
                OperationInterface.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
                EmptyText.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
                flag = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 更改线索的类型
/// </summary>
namespace SweetCandy.MisTrust
{
    public class ModifyClue : MonoBehaviour
    {
        public Text RightText; //右侧显示文本
        private Text LabelText; //标签文本
        public GameObject OperationInterface; //右侧控制面板
        public GameObject EmptyText; //默认空文本
        private void Start()
        {
            LabelText = gameObject.GetComponentInChildren<Text>();
        }
        public void displayClue() //传递Clue的内容
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
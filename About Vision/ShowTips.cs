using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// 用来显示按钮的类型的提示脚本
/// </summary>
namespace SweetCandy.MisTrust
{
    public class ShowTips : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Multiline]//允许多行输入
        public string Itext = "显示的文字"; //使用 相信，怀疑，有误
        public Text textpanel; //挂载至用来展示按钮类型的text
        private bool showText = false; //判断是否处于展示状态
        public void OnPointerEnter(PointerEventData eventData)
        {
            showText = true;
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            showText = false;
        }
        public void OnGUI()
        {
            if (showText)
                textpanel.text = Itext;
            else textpanel.text = "";
        }
    }
}
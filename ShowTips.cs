using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SweetCandy.MisTrust{
public class ShowTips : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [Multiline]//允许多行输入
    public string Itext = "显示的文字";
    public Text textpanel;
    private bool showText = false;
    void Start()
    {

    }

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
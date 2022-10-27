using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SweetCandy.MisTrust
{
    public static class Clue
    {
        [Serializable]
        public class clue
        {
            public int Key;
            public string text;
            public Clue.Type Type;
        };

        public enum Type { deny, trust, suspect };

        public static Dictionary<int, string> ClueArray = new Dictionary<int, string>();

        public static List<clue> OwnedClues = new List<clue>();
        public static clue showingClue = new clue();


        public static Dictionary<int, string> TotalClueArray = new Dictionary<int, string>
        {
            {0,"刚刚发生了一起车祸，你应该是坐在主驾驶位。现在你全身上下只有头部绑着绷带"},
            {1,"你们主驾的安全气囊失灵了"},
            {2,"自己可能有另一个名字“文浩”"},
            {3,"沈纤父亲一直在无条件支持你。"},
            {4,"你的母亲早逝,父亲也在去年因车祸去世"},
            {5,"你现在的公司本是北氏集团在w市子公司的雏形,在6年前独立"},
            {6,"你经常梦到一个和金茜长相十分相似的女孩，但是似乎并不是同一个人"},
            {7,"北氏集团和你的公司近几年有一定间接合作"},
            {8,"自己可能就叫“北文浩”"},
            {9,"北宇鸿的保释出了问题导致你见他比较麻烦，原因是他自己搞砸了"},
            {10,"北宇鸿的保释出了问题导致你见他比较麻烦，原因是有人想给他点教训"},
            {11,"北宇鸿的保释出了问题导致你见他比较麻烦，原因是有什么原因，不是单纯给他点教训而已"},
            {12,"北文浩是北氏集团的第二继承人"},
            {13,"金茜有个已故的姐姐金恬,两人长得很像"},
            {14,"金茜有个姐姐金恬几年前在Y市跳崖自杀,两人长得很像"},
            {15,"北文浩在金恬自杀的那段时间刚好失踪,最后出现在Y市"},
            {16,"莎娜以为我是鬼"},
            {17,"沈纤父亲这段时间与北氏集团有不少合作"},
            {18,"“北#%@￥%灭@￥%#”-----这是沈纤父亲奄奄一息时说的话"},
            {19,"“北文轩这么急着灭口吗？”-------沈纤父亲在车祸后说的话"},
        };
    }
}
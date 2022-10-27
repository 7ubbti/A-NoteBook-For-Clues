using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂载给标签预制件用以存储此标签的线索Key和种类
/// </summary>
namespace SweetCandy.MisTrust
{
    public class SaveLabel : MonoBehaviour
    {
        public int Key = -1;
        public Clue.Type type;
    }
}
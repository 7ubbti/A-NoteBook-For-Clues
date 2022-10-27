using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 挂载游戏开场重置静态变量
/// </summary>
namespace SweetCandy.MisTrust
{
    public class ResetClue : MonoBehaviour
    {
        void Start()
        {
            Clue.ClueArray.Clear();
            Clue.OwnedClues.Clear();
            ClueController.flag = false;

        }


    }
}

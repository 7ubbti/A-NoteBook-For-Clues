using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

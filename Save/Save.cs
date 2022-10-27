using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// 储存部分
/// </summary>
namespace SweetCandy.MisTrust
{

    [Serializable]
    public class Save
    {
        public List<Clue.clue> _OwnedClues = new List<Clue.clue>();
        //后续可加入存信任度

    }
}
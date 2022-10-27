using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SweetCandy.MisTrust
{

    [Serializable]
    public class Save
    {
        public List<Clue.clue> _OwnedClues = new List<Clue.clue>();
        //后续可加入存信任度

    }
}
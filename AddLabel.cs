using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SweetCandy.MisTrust
{
    public class AddLabel : MonoBehaviour
    {
        public GameObject LabelPrefab;
        public GameObject LabelPanel;
        public GameObject RedDot;
        public GameObject Page;
        //public GameObject[] LabelPrefabforOld;

        public Clue.Type t;

        public void add(Clue.Type type)
        {
            generateRedDot(type);
            GameObject instance = Instantiate(LabelPrefab, LabelPanel.GetComponent<Transform>(), true);
            instance.GetComponentInChildren<Text>().text = Clue.showingClue.text;
            instance.GetComponentInChildren<SaveLabel>().Key = Clue.showingClue.Key;
            instance.SetActive(true);
        }
        public void addOld()
        {
            foreach (Clue.clue c in Clue.OwnedClues)
            {
                if (c.Type == t)
                {
                    GameObject instance = Instantiate(LabelPrefab, LabelPanel.GetComponent<Transform>(), true);
                    instance.GetComponentInChildren<Text>().text = c.text;
                    instance.GetComponentInChildren<SaveLabel>().Key = c.Key;
                    instance.GetComponentInChildren<SaveLabel>().type = c.Type;
                    instance.SetActive(true);
                }
            }
        }
        public void generateRedDot(Clue.Type type)
        {
            if (type == t && !Page.activeSelf)
            {
                RedDot.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();//渐入
            }
        }

    }
}
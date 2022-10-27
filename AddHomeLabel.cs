using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SweetCandy.MisTrust
{
    public class AddHomeLabel : MonoBehaviour
    {
        public GameObject TrustLabelPrefab;
        public GameObject FalseLabelPrefab;
        public GameObject SuspectLabelPrefab;
        public GameObject LabelPanel;
        public GameObject RedDot;
        public GameObject Page;
        private Image image;
        private int i = 0;//添加到了第几条
        public void add(Clue.Type type)
        {
            if (!Page.activeSelf)
            {
                RedDot.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
            }
            GameObject instance;
            if (type == Clue.Type.trust)
            {
                instance = Instantiate(TrustLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
            }
            else if (type == Clue.Type.suspect)
            {
                instance = Instantiate(SuspectLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
            }
            else
            {
                instance = Instantiate(FalseLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
            }

            instance.GetComponentInChildren<Text>().text = Clue.showingClue.text;
            instance.GetComponentInChildren<SaveLabel>().Key = Clue.showingClue.Key;
            instance.SetActive(true);
        }
        public void addOld(int point)
        {

            GameObject instance;
            foreach (Clue.clue c in Clue.OwnedClues)
            {
                if (c.Type == Clue.Type.trust)
                {
                    instance = Instantiate(TrustLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
                }
                else if (c.Type == Clue.Type.suspect)
                {
                    instance = Instantiate(SuspectLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
                }
                else
                {
                    instance = Instantiate(FalseLabelPrefab, LabelPanel.GetComponent<Transform>(), true);
                }

                instance.GetComponentInChildren<Text>().text = c.text;
                instance.GetComponentInChildren<SaveLabel>().Key = c.Key;
                instance.GetComponentInChildren<SaveLabel>().type = c.Type;
                instance.SetActive(true);
            }
        }

    }
}
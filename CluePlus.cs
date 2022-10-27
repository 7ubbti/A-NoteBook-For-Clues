using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using System;
using System.IO;
using System.Text;

namespace SweetCandy.MisTrust
{
    public class GameCtrl : MonoBehaviour
    {
        public Animation anim;
        private string animname = "AwakeScreenEffect";
        public GameObject FadeCanvas;
        private Text showText;
        private string path_MotherDie;
        private string content_MotherDie;
        public GameObject EndCanvas;
        public GameObject clueController;
        private void Start()
        {
            path_MotherDie = Application.dataPath + "/judgeisTrustMotherDie.txt";
            if (FadeCanvas != null)
                showText = FadeCanvas.GetComponentInChildren<Text>();

        }
        public void Clueplus(string cluetag)
        {
            int c = System.Convert.ToInt32(cluetag);
            Debug.Log(Clue.OwnedClues.Exists(cl => cl.Key == c));
            if (!Clue.OwnedClues.Exists(cl => cl.Key == c))
            {
                Clue.ClueArray.Add(c, Clue.TotalClueArray[c]);
                Debug.Log(Clue.ClueArray.ContainsKey(c));
                clueController.SendMessage("displayClue", c);
            }


        }
        public void Show(string title)
        {
            FadeCanvas.GetComponent<CanvasGroup>().alpha = 1;
            showText.text = title;
            Invoke("Show_2", 2f);
        }
        public void Show_2()
        {
            FadeCanvas.GetComponent<CanvasGroup>().alpha = 0;
            anim.Play(animname);
        }


        public void endGame()
        {
            EndCanvas.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
            EndCanvas.GetComponent<GraphicRaycaster>().enabled = true;
            Animator endAnimator = EndCanvas.GetComponentInChildren<Animator>();
            endAnimator.SetBool("play", true);

        }
        public void JudgeVariable()
        {
            Debug.Log("OwnedCLues.Count =" + Clue.OwnedClues.Count);
            if (Clue.OwnedClues.Exists(c2 => c2.Key == 4 && c2.Type != Clue.Type.trust))
            {
                content_MotherDie = "True";
                Debug.Log("content_MotherDie = " + content_MotherDie);
            }
            else
            {
                content_MotherDie = "False";
            }
            File.WriteAllText(path_MotherDie, content_MotherDie, Encoding.UTF8);
        }

    }
}
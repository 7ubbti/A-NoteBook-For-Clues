using DG.Tweening;
//using Fungus.EditorUtils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SweetCandy.MisTrust
{
    public class BookMarkMoving : MonoBehaviour
    {
        public enum LabelType { isHomeLabel, notHomeLabel };
        [SerializeField]
        public LabelType labelType;
        bool isOver = false;
        private Vector3 StartPoint;
        private Vector3 EndPoint;

        public float MovingLeftDistance;
        public float MovingTime;

        public GameObject Page;
        public bool isPlaying;

        public BookMarkMoving AnotherBookMark1;
        public BookMarkMoving AnotherBookMark2;
        public BookMarkMoving AnotherBookMark3;

        private UI_FadeInFadeOut Page_ui_FadeInFadeOut;

        public GameObject RedDot;
        private void Start()
        {

            StartPoint = GetComponent<Transform>().position;
            if (labelType == LabelType.notHomeLabel)
                EndPoint = StartPoint + new Vector3(-MovingLeftDistance, 0, 0);
            else
                EndPoint = StartPoint + new Vector3(0, MovingLeftDistance, 0);

            Page_ui_FadeInFadeOut = Page.GetComponent<UI_FadeInFadeOut>();

        }
        public void MouseEnter()
        {
            isOver = true;
        }
        public void MouseExit()
        {
            isOver = false;
        }
        public void SetPlaying()
        {
            destroyRedDot();
            if (AnotherBookMark1.isPlaying)
                AnotherBookMark1.SetPlaying();
            else if (AnotherBookMark2.isPlaying)
                AnotherBookMark2.SetPlaying();
            else if (AnotherBookMark3.isPlaying)
                AnotherBookMark3.SetPlaying();
            isPlaying = !isPlaying;
            if (!isPlaying) Page_ui_FadeInFadeOut.UI_FadeOut_Event();
            else Page_ui_FadeInFadeOut.UI_FadeIn_Event();

        }
        private void Update()
        {

            if (isOver)
            {
                transform.DOMove(EndPoint, MovingTime);
            }
            else if (!isOver && !isPlaying)
            {
                transform.DOMove(StartPoint, MovingTime);
            }

        }
        public void destroyRedDot()
        {
            RedDot.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event(); //渐出
        }
    }
}
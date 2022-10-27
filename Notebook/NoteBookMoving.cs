using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Net;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace SweetCandy.MisTrust
{
    public class NoteBookMoving : MonoBehaviour
    {
        bool isOver = false;
        private Vector3 StartPoint;
        private Vector3 EndPoint;

        public float MovingUpwardsDistance;
        public float MovingTime;

        public GameObject NoteBookPage;
        private bool isPlaying;
        public GameObject RedDot;
        public AudioSource clickaudio;
        public AudioClip bookclickClip1;
        public AudioClip bookclickClip2;
        private void Start()
        {
            StartPoint = GetComponent<Transform>().position;
            EndPoint = StartPoint + new Vector3(0, MovingUpwardsDistance, 0);
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
            isPlaying = !isPlaying;
            if (isPlaying)
            {
                clickaudio.PlayOneShot(bookclickClip1);
                NoteBookPage.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
            }
            else
            {
                clickaudio.PlayOneShot(bookclickClip2);
                NoteBookPage.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
            }
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
            RedDot.GetComponent<UI_FadeInFadeOut>().UI_FadeOut_Event();
        }
        public void generateRedDot()
        {
            RedDot.GetComponent<UI_FadeInFadeOut>().UI_FadeIn_Event();
        }
        public void ShowSelf()
        {


        }
    }
}
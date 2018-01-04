using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Valve.VR.InteractionSystem
{
    [RequireComponent(typeof(Interactable))]
    [RequireComponent(typeof(AudioSource))]
    public class testscript : MonoBehaviour
    {
        private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers);

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void Awake()
        {
            Debug.Log("awakened!");
        }

        private void OnHandHoverBegin(Hand hand)
        {
            Debug.Log("oh yeah touch me more");
            //play the sound once when hand intersects with the object, dunno how
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(audio.clip);

        }

        private void OnHandHoverEnd(Hand hand)
        {
            Debug.Log("noo, touch me more :(");
        }

        private void HandHoverUpdate(Hand hand)
        {
            Debug.Log("Oh yeaahhhhh");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



namespace Valve.VR.InteractionSystem
{
    [RequireComponent(typeof(Interactable))]
    public class switchscene : MonoBehaviour
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
            StartCoroutine(SwitchThatShit(20));

        }

        private void OnHandHoverEnd(Hand hand)
        {
            Debug.Log("noo, touch me more :(");
        }

        private void HandHoverUpdate(Hand hand)
        {
            Debug.Log("Oh yeaahhhhh");
        }

        IEnumerator SwitchThatShit(int nowait)
        {
            print("Incoming terror!");
            yield return new WaitForSecondsRealtime(nowait);            
            SceneManager.LoadScene("coffin", LoadSceneMode.Single);
        }
    }
}
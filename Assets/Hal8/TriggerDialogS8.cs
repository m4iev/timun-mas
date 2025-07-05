using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TriggerDialogS8 : MonoBehaviour
{
    public Dialog dialog;

    public Animator animator;

    GraphicRaycaster raycaster;

    void Awake()
    {
        // Get both of the components we need to do this
        this.raycaster = GetComponent<GraphicRaycaster>();
    }


    void Update()
    {
        //Check if the left Mouse button is clicked
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Set up the new Pointer Event
            PointerEventData pointerData = new PointerEventData(EventSystem.current);
            List<RaycastResult> results = new List<RaycastResult>();

            //Raycast using the Graphics Raycaster and mouse click position
            pointerData.position = Input.mousePosition;
            this.raycaster.Raycast(pointerData, results);

            //For every result returned, output the name of the GameObject on the Canvas hit by the Ray
            foreach (RaycastResult result in results)
            {
                // Memunculkan Box Dialog
                if (result.gameObject.name == "BG")
                {
                    if  (animator.GetBool("IsOpen") == false)
                    {
                        FindObjectOfType<DialogManagerS8>().StartDialog(dialog);
                    }
                }

                // Memunculkan teks berikutnya
                if (result.gameObject.name == "BoxDialog")
                {
                    FindObjectOfType<DialogManagerS8>().KalimatBerikutnya();
                }
                
            }
        }
    }
}

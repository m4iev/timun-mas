using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TriggerDialogS9 : MonoBehaviour
{
    public Dialog dialog;

    public Animator animator, GordenKiri, GordenKanan;

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
                        FindObjectOfType<DialogManagerS9>().StartDialog(dialog);
                    }
                }

                // Memunculkan teks berikutnya
                if (result.gameObject.name == "BoxDialog")
                {
                    FindObjectOfType<DialogManagerS9>().KalimatBerikutnya();
                }

                if (result.gameObject.name == "GordenKiri")
                {
                    if (GordenKiri.GetBool("Klik") == false)
                    {
                        GordenKiri.SetBool("Klik", true);
                    } else
                    {
                        GordenKiri.SetBool("Klik", false);
                    }
                }

                if (result.gameObject.name == "GordenKanan")
                {
                    if (GordenKanan.GetBool("Klik") == false)
                    {
                        GordenKanan.SetBool("Klik", true);
                    } else
                    {
                        GordenKanan.SetBool("Klik", false);
                    }
                    
                }
                
            }
        }
    }
}

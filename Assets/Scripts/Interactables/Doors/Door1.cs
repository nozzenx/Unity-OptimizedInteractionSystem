using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : Interactable
{
    [SerializeField] Animator doorAnim;
    private bool isOpen;

    protected override void Interact()
    {
        doorAnim.SetTrigger("TryDoor");

        if (Key1.canOpenDoor1)
        {
            isOpen = !isOpen;
            doorAnim.SetBool("isOpen", isOpen);
        }
    }

}

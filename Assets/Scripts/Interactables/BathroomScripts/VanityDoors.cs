using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanityDoors : Interactable
{
    [SerializeField] Animator rDoor;
    [SerializeField] Animator lDoor;

    private bool isOpen;

    protected override void Interact()
    {
        isOpen = !isOpen;

        rDoor.SetBool("isOpen", isOpen);
        lDoor.SetBool("isOpen", isOpen);
    }
}

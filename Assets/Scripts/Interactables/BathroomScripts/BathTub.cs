using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathTub : Interactable
{
    [SerializeField] Animator doorAnim;
    private bool isOpen;
    protected override void Interact()
    {
        isOpen = !isOpen;
        doorAnim.SetBool("isOpen", isOpen);
    }

}

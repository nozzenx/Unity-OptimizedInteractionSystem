using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanityDrawers : Interactable
{
    [SerializeField] Animator anim;

    private bool isOpen;

    protected override void Interact()
    {
        isOpen = !isOpen;
        anim.SetBool("isOpen", isOpen);
    }
}

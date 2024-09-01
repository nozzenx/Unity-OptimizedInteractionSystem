using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : Interactable
{
    [SerializeField] Animator toiletAnim;
    private bool isOpen;
    protected override void Interact()
    {
        isOpen = !isOpen;
        toiletAnim.SetBool("isOpen", isOpen);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamper : Interactable
{
    [SerializeField] Animator hamperAnim;
    private bool isOpen;

    protected override void Interact()
    {
        isOpen = !isOpen;
        hamperAnim.SetBool("isOpen", isOpen);
    }
}

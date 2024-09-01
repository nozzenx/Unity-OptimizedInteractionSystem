using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : Interactable
{
    [SerializeField] GameObject doorRight;
    [SerializeField] GameObject doorLeft;
    private bool isOpen;

    protected override void Interact()
    {
        isOpen = !isOpen;
        Debug.Log("Interacted with" + gameObject.name);
        doorRight.GetComponent<Animator>().SetBool("isOpen", isOpen);
        doorLeft.GetComponent<Animator>().SetBool("isOpen", isOpen);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : Interactable
{
    [SerializeField] GameObject lamp;
    private bool isOpen = true;
    protected override void Interact()
    {
        isOpen = !isOpen;
        lamp.gameObject.SetActive(isOpen);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{
    [SerializeField] GameObject ceilingLight;
    private bool isOpen = true;
    protected override void Interact()
    {
        isOpen = !isOpen;
        ceilingLight.gameObject.SetActive(isOpen);
        
    }
}

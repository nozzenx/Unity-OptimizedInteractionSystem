using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : Interactable
{
    [SerializeField] GameObject lanternHand;
    protected override void Interact()
    {
        gameObject.SetActive(false);
        lanternHand.SetActive(true);
    }
}

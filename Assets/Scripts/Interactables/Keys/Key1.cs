using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : Interactable
{
    public static bool canOpenDoor1 = false;
    [SerializeField] Inventory inventory;
    [SerializeField] Key keyData;
    [SerializeField] Transform handTransform;
    protected override void Interact()
    {
        inventory.keys.Add(keyData);
        canOpenDoor1 = true;
        Destroy(gameObject);
    }
}

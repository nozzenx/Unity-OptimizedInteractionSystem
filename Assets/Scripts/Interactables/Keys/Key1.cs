using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1 : Interactable
{
    [SerializeField] Inventory inventory;
    [SerializeField] Key keyData;
    [SerializeField] Transform handTransform;
    protected override void Interact()
    {
        inventory.keys.Add(keyData);
        Destroy(gameObject);
    }
}

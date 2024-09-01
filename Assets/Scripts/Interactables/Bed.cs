using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : Interactable
{
    [SerializeField] GameObject animationObject;
    

protected override void Interact()
{
    Debug.Log("Interacted with" + gameObject.name);
    animationObject.GetComponent<Animator>().SetBool("MakeBed", true);
}

}

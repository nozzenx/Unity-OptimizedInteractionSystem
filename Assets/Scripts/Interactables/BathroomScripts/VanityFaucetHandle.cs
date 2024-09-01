using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanityFaucetHandle : Interactable
{
    [SerializeField] ParticleSystem waterParticle;
    [SerializeField] Animator anim;
    private bool isOpen;
    protected override void Interact()
    {
        isOpen = !isOpen;
        anim.SetBool("isOpen", isOpen);

        if (isOpen)
            waterParticle.Play();
        else
            waterParticle.Stop();
    }
}

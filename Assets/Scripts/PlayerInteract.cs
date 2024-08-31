using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField] float rayDistance;

    [SerializeField] LayerMask mask;
    private PlayerUI playerUI;

    private void Start()
    {
        cam = Camera.main;
        playerUI = GetComponent<PlayerUI>();
    }

    private void Update()
    {
        DrawRay();
    }

    private void DrawRay()
    {
        playerUI.UpdateText(string.Empty);

        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * rayDistance);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, rayDistance, mask))
        {
            if(hitInfo.collider.GetComponent<Interactable>() != null)
            {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.UpdateText(interactable.promptMessage);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}

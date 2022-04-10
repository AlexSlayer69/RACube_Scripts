using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Interaction : MonoBehaviour{
    [SerializeField] private float distance;
    [SerializeField] private LayerMask objectlayer;
    [SerializeField] private Camera cam;
    [SerializeField] private TMPro.TextMeshProUGUI interactionText;
    [SerializeField] private GameObject image; 
    
    private void Update(){
        bool successfulhit = false;
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));

        if (Physics.Raycast(ray, out hit, distance, objectlayer))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null){
                successfulhit = true;
                image.SetActive(true);
                interactionText.text = interactable.GetDescription();
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }
        if (!successfulhit){
            interactionText.text = "";
            image.SetActive(false);
        }
        
    }
}


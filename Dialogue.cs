using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {
    [SerializeField] private TMPro.TextMeshProUGUI interactionText;
    [SerializeField] private GameObject image;

    private void Start(){
        interactionText.text = "";
        image.SetActive(false);
    }
    public void SetDialogue(string str,AudioClip clip){
        SoundManager.instance.PlaySound(clip);
        interactionText.text = str;
        image.SetActive(true);
    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Q)){
            interactionText.text = "";
            image.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour{
    [SerializeField] private TMPro.TextMeshProUGUI interactiveText;
    public AudioClip clip1;
    private void Start(){
        SoundManager.instance.PlaySound(clip1);
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.E)){
            show(false);
            SetEnding("",null);
        }
    }

    public void show(bool b){
        gameObject.SetActive(b);
    }

    public void SetEnding(string str,AudioClip clip){
        //SoundManager.instance.PlaySound(clip);
        interactiveText.text = str;
    }
}

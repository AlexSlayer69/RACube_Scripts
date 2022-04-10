using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : Stats
{   
    [Header ("Health")]

   // [SerializeField] private AudioClip sound;
   // [SerializeField] private AudioClip death;
   // private Animator anim;
    private bool dead = false;
    
    [Header ("Iframes")]
    [SerializeField] private float inv = 5f;
    [SerializeField] private int num_flash = 4;


    private void Awake(){
        curr = max;
     //   anim = GetComponent<Animator>();
     //Mesh renderer for invinciblity
    }
  
    public override void Reduce(float damage){

        curr = Mathf.Clamp(curr - damage,0f,max);
        
        if(curr > 0){ 
           // anim.SetTrigger("Hurt");
           // SoundManager.instance.PlaySound(sound);
           // StartCoroutine(Invincible());
        }
        else if(!dead){
            //  anim.SetTrigger("Die");
            //  SoundManager.instance.PlaySound(death);
            Debug.Log("Dead");
           /* if(GetComponent<Player_Movement>() != null){              
                SceneManager.LoadScene("Game"); 
                GetComponent<Player_Movement>().enabled =false;
            }

            if(GetComponentInParent<Patrol>() != null)
                GetComponentInParent<Patrol>().enabled = false;
            
            if(GetComponent<Enemy>() != null)
                GetComponent<Enemy>().enabled = false;
            */
            dead = true;
            }
        }

    public override void Increase(float health){
        curr = Mathf.Clamp(curr + health,0f,max);
    }

    /*private IEnumerator Invincible(){

        //Ignore Collision from enemies

        for (int i = 0; i < num_flash; i++){
            //sp.color = new Color(1,0,0,0.5f);
           // yield return new WaitForSeconds(inv/num_flash);       
           /// sp.color = Color.white;
           // yield return new WaitForSeconds(inv/num_flash);     
        }
        //Ignore Collision
    
    }*/

    private void Deactivate(){
        gameObject.SetActive(false);
    }

}

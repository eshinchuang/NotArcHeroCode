using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace RPGCharacterAnimsFREE{
    public class PlayerManage : MonoBehaviour
    {   
        private RPGCharacterControllerFREE rpgCharacterController;
        bool dead;
        public Scrollbar lifebar;
        public ParticleSystem ef;
        public AudioSource audioSrc;
        public AudioClip SE;
        // Start is called before the first frame update
        void Awake()
        {
            dead = false;
            rpgCharacterController = GetComponent<RPGCharacterControllerFREE>();
        }

        // Update is called once per frame
        void Update()
        {
            if(dead == false){
                if(lifebar.size <= 0){
                    rpgCharacterController.Death();
                    dead = true;
                }
            }
        }
        private void OnTriggerEnter(Collider other){ 
            /*if(other.CompareTag("Monster")){
                lifebar.size -= 0.3f;
            }  */
            if(other.CompareTag("bullet")){
                audioSrc.PlayOneShot(SE);
                lifebar.size -= 0.2f;
                ef.Play();
            }
        }

    }
}
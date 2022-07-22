using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2AI : MonoBehaviour
{
    public float HP;
    public GameObject p;
    float CurTime = 2.0f;
    public float frequency = 4.0f;
    public ParticleSystem ef;
    public AudioSource audioSrc;
    public AudioClip SE;
    private Rigidbody rb;
    private Collider c;
    void Start()
    {   
        HP = 5;
        ef.transform.position = gameObject.transform.position;
        rb = this.gameObject.GetComponent<Rigidbody>();
        c = this.gameObject.GetComponent<Collider>();
        
    }

    void Update()
    {   
        transform.LookAt(new Vector3(p.transform.position.x, this.transform.position.y, p.transform.position.z));
        charge();
        
    }
    void FixedUpdate(){

    }
    private void charge(){
        
        if(CurTime <= 0.0f){
            CurTime = frequency;
            rb.AddForce(1200.0f * gameObject.transform.forward);
        }
        else 
            CurTime -= Time.deltaTime;
    }
    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Weapon")){
            audioSrc.PlayOneShot(SE);
            ef.Play();
            HP -= 1;
        }
        if(HP <= 0){
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterAI : MonoBehaviour
{
    public float HP;
    public GameObject p;
    public GameObject bullet;
    GameObject shoot;
    float CurTime = 3.0f;
    public float frequency = 3.0f;
    public ParticleSystem ef;
    public AudioSource audioSrc;
    public AudioClip SE;
    void Start()
    {   
        HP = 2;
        ef.transform.position = gameObject.transform.position;
    }

    void Update()
    {   
        transform.LookAt(new Vector3(p.transform.position.x, this.transform.position.y, p.transform.position.z));
        shooting();
    }

    void shooting(){
        if(CurTime <= 0.0f){
            CurTime = frequency;
            shoot = Instantiate(bullet, gameObject.transform.position + gameObject.transform.forward*1.0f, Quaternion.identity); 
            shoot.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 500.0f);
        }
        else 
            CurTime -= Time.deltaTime;
    }
    void FixedUpdate(){

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

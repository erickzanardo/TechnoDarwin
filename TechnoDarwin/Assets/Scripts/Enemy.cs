using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public float noiseInc;
    

    private Animator animator;
    public GameObject bloodEffect;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int dam){
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= dam;
        Debug.Log("Damage taken");
    }

}

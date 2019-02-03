using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    Rigidbody2D rb;
    public Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


   

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        animator.SetFloat("speed", Mathf.Abs(moveHorizontal) + Mathf.Abs(moveVertical));
        rb.transform.Translate(movement * speed * Time.deltaTime);
    }
}

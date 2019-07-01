using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierControllerScripts : MonoBehaviour
{

    public float maxspeed = 10f;
    bool facingRight = true;

    //Reference to animator
    Animator anim;


    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("speed", Mathf.Abs(move));

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxspeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }          
    

    void Flip(){
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}

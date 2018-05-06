using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    private Animator anim;
    private Rigidbody2D prb2d;
    private SpriteRenderer spriteRender;


    private void Start() {
        anim = GetComponent<Animator>();
        prb2d = GetComponent<Rigidbody2D>();
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        // Horizontal movement, different for both for flip
        if (Input.GetAxisRaw("Horizontal") > 0.5f) {
            spriteRender.flipX = true;
            prb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, prb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < -0.05f)
        {
            spriteRender.flipX = false;
            prb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, prb2d.velocity.y);
        }
        // Vertical movement
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.05f) {
            prb2d.velocity = new Vector2(prb2d.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        }

        // Smoothing walking
        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f) {
            prb2d.velocity = new Vector2(0f, prb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f) {
            prb2d.velocity = new Vector2(prb2d.velocity.x, 0f);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}

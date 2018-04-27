using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed;
    private Animator anim;
    private Rigidbody2D prb2d;


    private void Start() {
        anim = GetComponent<Animator>();
        prb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.05f) {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            prb2d.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, prb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.05f) {
            //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            prb2d.velocity = new Vector2(prb2d.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
        }
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

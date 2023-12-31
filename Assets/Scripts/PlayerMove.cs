using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;

    public float moveX = 1;
    public float curY; // Player�� ���� Y��ǥ

    private bool isWalkFirst = true;
    private bool isIdleNow = false;
    private Animator animator;

    GrapplingHook grappling;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        grappling = GetComponent<GrapplingHook>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveX;

        moveDelta = new Vector3(x, 0, 0);

        if (isWalkFirst && x != 0 && !grappling.isAttach)
        {
            isWalkFirst = false;
            isIdleNow = false;
            animator.Play("move");
        }

        if (!isIdleNow && x == 0)
        {
            isWalkFirst = true;
            isIdleNow = true;
            animator.Play("idle");
        }

        if (grappling.isAttach)
        {
            isWalkFirst = true;
            isIdleNow = true;
            animator.Play("idle");
        }



        if (moveDelta.x > 0)
        {
            transform.localScale = new Vector3(2.5f, 2.5f, 1);
        }    
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-2.5f, 2.5f, 1);
        }
        transform.Translate(moveDelta * Time.deltaTime * 2);
    }

    private void Update()
    {
        curY = transform.position.y;
        if (curY > 100)
        {
            SceneManager.LoadScene("BossStageScene");
        }
    }
}

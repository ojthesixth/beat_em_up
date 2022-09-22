using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPC1 : MonoBehaviour
{
    private float Mouvement;
    public float _speed = 1f;
    public GameObject player;
    public Rigidbody2D _rigidbody;
    public BoxCollider2D _collider2D;
    public Vector2 direction;

    //public float runSpeed = 2f;

    /*
    
    private bool isjumpPressed;
    public float jumpForce) = __f ;
    private int groundMask;
    private bool isGrounded;

    private string currentAnimation;
    private bool isAttackPressed;
    private bool isAttacking;
    private float xAxis;
    private float yAxis;

    const string idle-pc1 = "idle";
    const string walk-pc1 = "walk";
    const string run-pc1 = "run";
    const string jump-pc1 = "jump";
    const string jump-fall-pc1 = "fall";
    
    const string grab-pc1 = "grab";
    const string hold-idle-pc1 = "hold_idle";
    const string hold-walk-pc1 = "hold_walk";
    const string hold-run-pc1 = "hold_run";
    const string hold-jump-pc1 = "hold_jump";
    const string hold-jump-fall-pc1 = "hold_fall";
    const string throw-pc1 = "throw";

    const string punch1-pc1 = "punch1";
    const string punch2-pc1 = "punch2";
    const string punch3-pc1 = "punch3";
    const string punch4-pc1 = "punch4";
    const string punch5-pc1 = "punch5";
    const string punch6-pc1 = "punch6";
    const string punch7-pc1 = "punch7";
    const string punch8-pc1 = "punch8";
    
    */

    Animator animator;
    int isWalkingHash;
    int isRunningHash;

    void Start()
    {
        GetComponent<Animator>();
        //groundMask = 1 << LayerMask.NameToLayer("Ground");

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void ChangeAnimationState(string newState)
    {
        /*
        if (currentState == newState) return;
        animator.Play(newState);
        currentState = newState;
        */
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;

        //float run = Input.GetButtonDown("0") * _speed;

        _rigidbody.velocity = new Vector2(r, v);


        /*
        if (isAttackingPressed)
        {
            isAttacking = true;
            if{
                ChangeAnimationState(punch1-pc1);
            }
            else
            {
                ChangeAnimationState(punch1-pc1);
            }
            Invoke("punch1")
        }
        */

        bool isRunning = animator.GetBool("isRunningHash");
        bool isWalking = animator.GetBool("isWalkingHash");
        bool forwardPressed = Input.GetKey("Horizontal");
        bool runPressed = Input.GetKey("0");

        if(isWalking && forwardPressed)
        {
            animator.SetBool("isWalkingHash", true);
        }
        if(isWalking && forwardPressed)
        {
            animator.SetBool("isWalkingHash", false);
        }
        
        if(isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunningHash", true);
        }
        if(isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunningHash", false);
        }



    }

    private void FixedUpdate()
    {
        /*
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, groundMask);
        if(hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        Vector2 vel = new Vector2(0, -_rigidbody.velocity.y);
        if(xAxis < 0)
        {
            vel.x = -walkSpeed;
            transform.localScale = new Vector2(-1, 1);
        }
        else if (xAxis > 0)
        {
            vel.x = walkSpeed;
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            vel.x = 0;
        } */
    }

}

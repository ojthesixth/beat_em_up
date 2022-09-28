using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robSCRIPT : MonoBehaviour
{
    [SerializeField] private float speed;
    public Rigidbody2D rb;
    public Animator anim;
    public GameObject player;
    public Rigidbody2D _rb;

    int isWalkingHash;
    int isRunningHash;

    bool isWalking;
    bool isRunning;

    bool Grabbed;

    /* public float jumpForce = 1f;
    private int groundMask;
    private bool isGrounded; */

    private void Start()
    {
        GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

        //GetComponent<StateMachineBehaviour>();

        //groundMask = 1 << LayerMask.NameToLayer("Ground");

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);


        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        anim.SetBool("isWalking", horizontalInput != 0);

        // float run = Input.GetButtonDown("0"); | lowkey giving up on run anim cause not working
        // +just had to fix the whole grab>throw>idle anim, much exhaustion.

        if (Input.GetKeyDown(KeyCode.E))
            anim.SetTrigger("Punch");


        if (Input.GetKeyDown(KeyCode.G))
            anim.SetTrigger("Grab");

        /* if (Input.GetKeyDown(KeyCode.R))
            anim.SetBool("isRunning", true); | doesnt work, get stuck + same speed as walk */


        /* need have it go : if grab -> throw, once thrown -> idle
        or/also if grab -> hold-idle -> hold-walk>run>jump then throw>idle
        but how do i code that, triggers wont work, float dont seem to work so far
        maybe bool will? | can prob reuse SpeedWalk/RunSpeed, even thought they dont work,
        they, in theory, should work for hold-walk/run, same condition and all,
        like in math class, not the result that count but the process behind it, probably. ;_; */

        if (Grabbed = true && (Input.GetKeyDown(KeyCode.T)))
        {
            anim.SetBool("Grabbed", true);
            anim.SetTrigger("Grab");
        }
        // doesnt woooorrkk | maybe should forget about this and go for the jump instead | jump didnt work, what do now |
        // FINALLY IT WORKS thanks to help from fellows students 

    }

    private void FixedUpdate() {
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

           Vector2 vel = new Vector2(0, _rb.velocity.y);
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

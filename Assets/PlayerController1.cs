using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController1 : MonoBehaviour
{/*
    bool leftMove;
    bool rightMove;
    float maxHP = 5;
    float currentHP = 5;

    public Image hpImage;
    public float speed = 7f;
    public float jumpPower = 5f;
    int jumpCount;

    public AudioClip pickUpSound;
    public AudioClip jumpSound;
    AudioSource AudioSource;
    Animator animator;

        // Start is called before the first frame update
    void Start()
    {
        AudioSource = this.gameObject.GetComponent<AudioSource>();
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animation();


    }
    void Move()
    {
        if (Input.GetKey("right") || rightMove == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
           }
        if(Input.GetKeyDown("space"))
        {
            Jump();
        }
    }
    public void Jump()
    {
        if(jumpCount<2)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            AudioSource.clip = jumpSound;
            AudioSource.Play();
            jumpCount++;
        }
    }
    void Animation()
    {
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("WallRight", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("WallkRight", false);
        }

        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("WallRight", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("WallkRight", false);
        }
    }


    // 当たり判定
    private void OnCollisEnter(Collision col)
    {
        if(col.gameObject.tag=="Ground")
        {
            jumpCount = 0;
         }
        if(col.gameObject.tag=="Coin")
        {
            AudioSource.clip = pickUpSound;
            AudioSource.Play();
            Destroy(col.gameObject);
                            }
        if(col.gameObject.tag=="Doragon")
        {
            currentHP -= 1;
            hpImage.fillAmount = currentHP / maxHP;

        }
    }
    public void leftButtonDown()
    {
        leftMove = true;
        animator.SetBool("wallkleft", true);
    }
    public void leftButtonUp()
    {
        leftMove = false;
        animator.SetBool("wallkLeft", false);
    }
    public void righButtonDown()
    {
        rightMove = true;
        animator.SetBool("WallkLeft", true);
    }
    public void rightButtonUp()
    {

        rightMove = false;
        animator.SetBool("wallRight", false);


    }


    */




}

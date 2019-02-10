using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController2 : MonoBehaviour
{
    /*

    //移動ボタン処理
    bool leftMove;

    bool rightMove;

    float maxHP = 5;
    //現在のHP
    float currentHp = 5;

    //HP Image宣言
    public Image hpImage;
    public float speed = 7f;
    int jumpCount;

    //音のファイル作成
    public AudioClip JumpSound;
    public AudioClip pickUpSound;

    AudioSource audioSource;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Animator();


    }
    void Move()
    {
        if (Input.GetKey("right") || rightMove == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("left") || leftMove == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            Jump();

        }
    }
    public void Jump()
    {
        if (jumpCount < 2)
        {

            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            audioSource.clip = JumpSound;
            audioSource.Play();
            jumpCount++;

        }
    }
    void Animation()
    {
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("walkRight", true);

        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("walkRight", false);
        }
        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("walkLeft", false);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("WallkLeft", false);

        }
    }

    //当たり判定
    void OnCollisonEnter(Collision col)
    {
        if (col.gameObject.tag == "Groud")
        {
            jumpCount = 0;
        }
        if (col.gameObject.tag == "Coin")
        {
            audioSource.clip = pickUpSound;
            audioSource.Play();

            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Dorgon")
        {
            currentHp -= 1;
            hpImage.fillAmount = currentHp / maxHP;
        }
    }
    public void leftButtonDown()
    {
        leftMove = true;
        animator.SetBool("walkLeft",false);
    }
    public void rightButtonUp()
    {
        rightMove = false;
        animator.SetBool("WalkRight", false);
    }
    */
}


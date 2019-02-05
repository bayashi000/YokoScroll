using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIを使う時
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    /*
     * Animator
     * Animationの切り替えを管理するためのデータ
     * 
     * Animation
     * 名前の通りアニメーションのデータ   
     * 
     */

    float maxHP = 5;
    //現在のHP
    float currentHP = 5;

    //HPimageを宣言
    public Image hpImage;
    public float speed = 7f;
    public float jumpPower = 5f;
    int jumpCount;

    //音のファイルを作る
    public AudioClip pickUpSound;

    public AudioClip jumpSound;

    //核の省略
    AudioSource audioSource;

    //animatiorの省略
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
        /*
         * Input.GetKey("")
         * 押した間ずっと
         * 
         * Input.GetKeyDown("")
         * 押した瞬間だけ
         * 
         * ifぶんの条件の書き方
         * 
         * A && B AかつB
         * A || B AまたはB       
         */


        Move();

        Animation();

        /*
        if(Input.GetKeyDown("space") == true)
        {
            this.gameObject.GetComponent<BoxCollider>().isTrigger = true;
        }
        */
    }

    void Move()
    {
        //右移動
        if (Input.GetKey("right"))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        //左移動
        if (Input.GetKey("left"))
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("space") && jumpCount < 2)
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            audioSource.clip = jumpSound;
            audioSource.Play();
            jumpCount++;
        }
    }

    void Animation()
    {
        //右アニメーション
        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("WallkRight", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("WallkRight", false);
        }



        //左アニメーション
        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("WallkLeft", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("WallkLeft", false);
        }
    }

    //当たり判定
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
        }
        if(col.gameObject.tag == "Coin")
        {
            audioSource.clip = pickUpSound;
            audioSource.Play();

            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "Doragon")
        {
            currentHP -= 1;
            hpImage.fillAmount = currentHP / maxHP;
        }
    }
}

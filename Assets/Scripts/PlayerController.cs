using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIを使う時
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


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

    //timerText宣言
    public Text timerText;

    public Text CoinText;

    float timer = 0.0f;
    int coinCount;


    //ゴールしているか、してないか　初期値　false
    bool cleared = false;



    //fonts
    public GUIStyle labelStyle;


    //移動のボタンの処理
    bool leftMove;

    bool rightMove;

    float maxHP = 5;
    //現在のHP
    float currentHP = 5;

    //HPimageを宣言
    public Image hpImage;
    public float speed = 7f;
    public float jumpPower = 90f;
    int jumpCount;

    //音のファイルを作る
    public AudioClip pickUpSound;

    public AudioClip jumpSound;

    //BGM
    //public AudioClip BGM;

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


        timer += Time.deltaTime;
        timerText.text = timer.ToString("f2");

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
        if (Input.GetKey("right") || rightMove == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        //左移動
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
        if (jumpCount <= 5)
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
        if (col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
        }

        //コインに当たった時
        if (col.gameObject.tag == "Coin")
        {
            audioSource.clip = pickUpSound;
            audioSource.Play();

            coinCount++;
            CoinText.text = coinCount.ToString();

            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Doragon")
        {
            currentHP -= 1;
            hpImage.fillAmount = currentHP / maxHP;
        }


        //ゴールにぶつかった時
        if (col.gameObject.tag == "Goal")
        {
            cleared = true;
            /*
            PlayerPrefs.SetFloat("score", timer);
            SceneManager.LoadScene("Goal");
            */           
        }

    }

    void OnGUI()
    {
        if (cleared == true)
        {
            int sw = Screen.width;
            int sh = Screen.height;
            //C#だとこうかく
            GUI.Label(new Rect(sw / 6, sh / 3, sw * 2 / 3, sh / 3), "CLEARED!!", labelStyle);

        }
    }

    public void leftButtonDown()
    {
        leftMove = true;
        animator.SetBool("WallkLeft", true);
    }
    public void leftButtonUp()
    {
        leftMove = false;
        animator.SetBool("WallkLeft", false);
    }
    public void rightButtonDown()
    {
        rightMove = true;
        animator.SetBool("WallkRight", true);
    }
    public void rightButtonUp()
    {
        rightMove = false;
        animator.SetBool("WallkRight", false);
    }
}

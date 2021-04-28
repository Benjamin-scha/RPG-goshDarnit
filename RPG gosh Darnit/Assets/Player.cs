using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

    public Transform Camera;
    public Rigidbody rb;
    public float jumpforce;

    public SpriteRenderer _sprite;

    public List<Sprite> sprites = new List<Sprite>();

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    int animateSprite;
    float animtimer;

    bool left;
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, Camera.eulerAngles.y, 0);

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {


            if (animtimer > .06f)
            {
                animateSprite++;
                animtimer = 0;
            }

            animtimer += Time.deltaTime;


            if (animateSprite > sprites.Count-1)
            {
                animateSprite = 1;
            }
        }
        else
        {
            animateSprite = 0;
        }

        _sprite.sprite = sprites[animateSprite];
        


        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, speed * Input.GetAxis("Vertical"));

        if (Input.GetKeyDown("space"))
        {

            rb.AddForce(Vector3.up * jumpforce);
        }

   

        if (Input.GetAxis("Horizontal") > 0)
        {
            left = true;
        }else if (Input.GetAxis("Horizontal") < 0)
        {
            left = false;
        }


    

     

        anim.SetBool("isleft", left);

        //
        /* Vector3 mover = new Vector3(Input.GetAxis("Horizontal") * speed, 0, speed * Input.GetAxis("Vertical"));

         transform.Translate(Camera.TransformDirection(mover),Space.World);

         if (Input.GetKeyDown("space"))
         {

             rb.AddForce(Vector3.up*jumpforce);
         }


         float camy = Camera.eulerAngles.y;

         if (Input.GetAxis("Horizontal") > 0)
         {
             if (transform.eulerAngles.y < 175-camy || transform.eulerAngles.y > 185 - camy) 
             {
                 if (transform.eulerAngles.y < 180)
                 {
                     transform.Rotate(0, 5, 0);
                 }
                 else
                 {
                     transform.Rotate(0, -5, 0);
                 }
             }


         }
         if (Input.GetAxis("Horizontal") < 0)
         {
             if(transform.eulerAngles.y > 5 - camy && transform.eulerAngles.y < 355 - camy)
             {
                 {
                     if (transform.eulerAngles.y > 180)
                     {
                         transform.Rotate(0, 5, 0);
                     }
                     else
                     {
                         transform.Rotate(0, -5, 0);
                     }
                 }
             }


         }*/




        if (Input.GetKeyDown("q"))
        {

        }

    }
}

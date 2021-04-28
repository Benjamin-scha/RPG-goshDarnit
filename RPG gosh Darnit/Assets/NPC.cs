using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed;

    public Transform Camera;
    public Rigidbody rb;
    public float jumpforce;

    public SpriteRenderer _sprite;

    public List<Sprite> sprites = new List<Sprite>();

    public Animator anim;


    int animateSprite;
    float animtimer;

    bool left;
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, Camera.eulerAngles.y, 0);

        if (sprites.Count > 0 && _sprite != null)
        {
            /* if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
                     {


                         if (animtimer > .06f)
                         {
                             animateSprite++;
                             animtimer = 0;
                         }

                         animtimer += Time.deltaTime;


                         if (animateSprite > sprites.Count - 1)
                         {
                             animateSprite = 1;
                         }
                     }
                     else
                     {
                         animateSprite = 0;
                     }

                     _sprite.sprite = sprites[animateSprite];

                     */
        }


        transform.Translate(Input.GetAxis("Horizontal") * speed, 0, speed * Input.GetAxis("Vertical"));

        if (Input.GetKeyDown("space"))
        {

            rb.AddForce(Vector3.up * jumpforce);
        }



        if (transform.InverseTransformDirection( rb.velocity).x > 1)
        {
            left = true;
        }
        else if (transform.InverseTransformDirection(rb.velocity).x < -1)
        {
            left = false;
        }



        if (Input.GetMouseButton(0))
        {
            rb.AddRelativeForce(10, 0, 0);
        }
        if (Input.GetMouseButton(1))
        {
            rb.AddRelativeForce(-10, 0, 0);
        }


        anim.SetBool("isleft", left);
    }
}
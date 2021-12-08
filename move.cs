using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private static bool isFacingRight = true;
    public float horSpeed;
    float speedX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow))
        {

            speedX = -horSpeed;
          

            

            
            if (speedX < 0 && isFacingRight)
            {
                Flip();

            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            speedX = horSpeed;
         

          
            if (speedX > 0 && !isFacingRight)
            {
                Flip();

            }
        }

       void Flip()
        {
            //меняем направление движения персонажа
            isFacingRight = !isFacingRight;
            //получаем размеры персонажа
            Vector3 theScale = transform.localScale;
            //зеркально отражаем персонажа по оси Х
            theScale.x *= -1;
            //задаем новый размер персонажа, равный старому, но зеркально отраженный
            transform.localScale = theScale;
        }
        //if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        //{

        //    //State = CharState1.jump;
        //    // rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        //    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        //}
        transform.Translate(speedX, 0, 0);
        speedX = 0;

        


    }

}


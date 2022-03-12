using UnityEngine;

public class PlayerPaddle : Paddle
{
   private Vector2 direction;

   private void Update()
   {
       //If you press up... you move up and vice versa
       //pretty simple stuff
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
       {
           direction = Vector2.up;
       }
       else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
       {
           direction = Vector2.down;
       }
       else
       {
           //If you're not moving up or down you're staying still
           direction = Vector2.zero;
       }
   }

   private void FixedUpdate()
   {
       if(direction.sqrMagnitude != 0)
       {
           rigidbody.AddForce(direction * this.speed);
       }
   }
}

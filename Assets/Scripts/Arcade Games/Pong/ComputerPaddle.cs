using UnityEngine;

public class ComputerPaddle : Paddle
{
   //The computers AI

   //I followed this pong tutorial so if I get anything wrong then 
   //feel free to correct me
   //https://www.youtube.com/watch?v=AcpaYq0ihaM

   public Rigidbody2D ball;

   private void FixedUpdate()
   {
       //The paddle will hang in the middle of the screen
       if(this.ball.velocity.x > 0.0f)
       {
           if(this.ball.position.y > this.transform.position.y)
           {
               //If the ball moving upwards then so will the paddle
               rigidbody.AddForce(Vector2.up * this.speed);
           }
           else if(this.ball.position.y < this.transform.position.y)
           {
               //If the ball moving downwards then so will the paddle
               rigidbody.AddForce(Vector2.down * this.speed);
           }
       }
       else
       {   
           //The paddle will stay around the middle of the screen
           if (this.transform.position.y > 0.0f)
           {
               rigidbody.AddForce(Vector2.down * this.speed);
           }
           else if (this.transform.position.y < 0.0f)
           {
               rigidbody.AddForce(Vector2.up * this.speed);
           }
       }

       
   }
}

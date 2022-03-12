using UnityEngine;

public class Ball : MonoBehaviour
{
   public Rigidbody2D rigidbody;
   
   public float speed = 200.0f;
   public GameObject pongball;

   public void Start()
   {
     rigidbody = GetComponent<Rigidbody2D>();
     ResetPosition();
     AddStartingForce();
   }
   
   public void ResetPosition()
   {
     //Resets the balls position
     rigidbody.position = Vector3.zero;
     rigidbody.velocity = Vector3.zero;
   }


   public void AddStartingForce()
   {
     //Sends the ball flying in a random direction
     float x = Random.value < 0.5f ? -1.0f : 1.0f;
     float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f):Random.Range(0.5f, -1.0f);
     Vector2 direction = new Vector2(x, y);
     rigidbody.AddForce(direction * this.speed);
   }

   public void AddForce(Vector2 force)
   {
     rigidbody.AddForce(force);
   }



}

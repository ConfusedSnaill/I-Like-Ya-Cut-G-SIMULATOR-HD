using UnityEngine;

public class Paddle : MonoBehaviour
{
   protected Rigidbody2D rigidbody;
   public float speed = 10.0f;

   private void Awake()
   {
      rigidbody = GetComponent<Rigidbody2D>();
   }
   
   public void ResetPosition()
   {
      //Resets both paddles positions
      rigidbody.position = new Vector2(rigidbody.position.x, 0.0f);
      rigidbody.velocity = Vector3.zero;
   }
}

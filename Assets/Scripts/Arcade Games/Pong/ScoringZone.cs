using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
   public EventTrigger.TriggerEvent scoreTrigger;

   private void OnCollisionEnter2D(Collision2D collision)
   {
      Ball ball = collision.gameObject.GetComponent<Ball>();

      //If the scoring zone collides with the ball the opposite side score a point
      if(ball != null)
      {
        BaseEventData eventData = new BaseEventData(EventSystem.current);
        this.scoreTrigger.Invoke(eventData);
      }
   }

}

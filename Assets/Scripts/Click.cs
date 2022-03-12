using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
   public static bool x2Click;

   public void Clicker()
   {
      //If the x2 score multiplier is turned on it will change from adding +1 to your score
      //to adding +2 which seems kind of obvious but I just wanted to point that out

      if(x2Click == false)
      {
        ClickableG.ScoreCount += 1;
      }
      else
      {
        ClickableG.ScoreCount += 2;
      }

   }

   public void Clickerx2()
   {
      //I'm unsure about this because I thought that Switchx2CheckBox(); from the x2CheckBox script
      //was what was changing it On/Off?

      if(x2Click == false)
      {
        x2Click = true; 
      }
      else
      {
        x2Click = false;
      }
     
      //I'll look back at this when I start working on the next update...
   }

}

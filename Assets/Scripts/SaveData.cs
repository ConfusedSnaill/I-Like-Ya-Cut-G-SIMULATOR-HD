using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
   //The score from the "Clickable G" script
   public int ScoreCount;

   //The reward bools from the "MileStones" script
   public bool reward1, reward2, reward3, reward4, reward5;
   public bool playonce1, playonce2, playonce3, playonce4, playonce5;

   public SaveData (ClickableG clickG)
   {
     //Making the variables from this script the same as the original ones so they can be loaded in-game
       ScoreCount = ClickableG.ScoreCount;
      
       reward1 = MileStones.reward1;
       reward2 = MileStones.reward2;
       reward3 = MileStones.reward3;
       reward4 = MileStones.reward4;
       reward5 = MileStones.reward5;

       playonce1 = MileStones.playonce1;
       playonce2 = MileStones.playonce2;
       playonce3 = MileStones.playonce3;
       playonce4 = MileStones.playonce4;
       playonce5 = MileStones.playonce5;

   }
}


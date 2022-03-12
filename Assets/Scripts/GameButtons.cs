using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameButtons : MonoBehaviour
{
  //Rewards that you unlock
  public GameObject x2ScoreDisplay;
  public GameObject BruhButtonDisplay;
  public GameObject ArcadeButtonDisplay;
  public GameObject ParticleDisplay;

   public void ResetScore()
   {
     //Sets everything back to the state they're in at the beginning of the game
     
     //Resets the score counter
     ClickableG.ScoreCount = 0;


     //Resets the Bruh Button     
     BruhCheckBox.bruhtick = false;
     BruhButtonDisplay.SetActive(false);

     //Resets back to x1 Score
     Click.x2Click = false;
     x2CheckBox.x2tick = false;
     x2ScoreDisplay.SetActive(false);

     //Reset the Arcade Machine
     ArcadeCheckBox.arcadetick = false;
     ArcadeButtonDisplay.SetActive(false);

     //Resets the Particle Button
     ParticleCheckbox.particletick = false;
     ParticleDisplay.SetActive(false);
     
   }
}

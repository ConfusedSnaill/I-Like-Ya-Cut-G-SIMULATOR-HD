using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ParticleCheckbox : MonoBehaviour
{
  //imageSprite is the actual image itself and boxchecked/boxunchecked are sprites for the checkbox
   public Image imageSprite;
   public Sprite boxchecked;
   public Sprite boxunchecked;

   public static bool particletick;
   public GameObject particle;

   public void Update()
   {

      //This makes sure the checkbox is ticked or unticked when you click it
      if(particletick == true)
      {
        imageSprite.sprite = boxchecked;
        particle.SetActive(true);
      }
      else
      {
        imageSprite.sprite = boxunchecked;
        particle.SetActive(false);
      }

   }

   //Used when resetting your save file
   public void ResetParticle()
   {
      particle.SetActive(false);
   }

   public void SwitchParticleCheckBox()
   {

     //Switches between being On/Off
     if(particletick == true)
      {
        particletick = false;
      }
      else
      {
        particletick = true;
      }

   }

}

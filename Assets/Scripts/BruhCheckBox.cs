using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BruhCheckBox : MonoBehaviour
{
  //imageSprite is the actual image itself and boxchecked/boxunchecked are sprites for the checkbox
   public Image imageSprite;
   public Sprite boxchecked;
   public Sprite boxunchecked;

   public static bool bruhtick;
   public GameObject bruh;

   public void Update()
   {

      //This makes sure the checkbox is ticked or unticked when you click it
      if(bruhtick == true)
      {
        imageSprite.sprite = boxchecked;
        bruh.SetActive(true);
      }
      else
      {
        imageSprite.sprite = boxunchecked;
        bruh.SetActive(false);
      }

   }

   //Used when resetting your save file
   public void Resetbruh()
   {
      bruh.SetActive(false);
   }

   public void SwitchBruhCheckBox()
   {

       //Switches between being On/Off
      if(bruhtick == true)
       {
         bruhtick = false;
       }
       else
       {
         bruhtick = true;
       }

   }

}
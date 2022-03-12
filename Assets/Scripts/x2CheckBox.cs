using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class x2CheckBox : MonoBehaviour
{
  //imageSprite is the actual image itself and boxchecked/boxunchecked are sprites for the checkbox
   public Image imageSprite;
   public Sprite boxchecked;
   public Sprite boxunchecked;

   public static bool x2tick;
   public GameObject x2score;

   public void Update()
   {

      //This makes sure the checkbox is ticked or unticked when you click it
      if(Click.x2Click == true && x2tick == true)
      {
        imageSprite.sprite = boxchecked;
        x2score.SetActive(true);
      }
      else
      {
        imageSprite.sprite = boxunchecked;
        x2score.SetActive(false);
      }

   }

    //Used when resetting your save file
   public void Resetx2()
   {
       x2score.SetActive(false);
   }

   public void Switchx2CheckBox()
   {

      //Switches between being On/Off
      if(Click.x2Click == true)
      {
         Click.x2Click = false;
         x2tick = false;
      }
      else
      {
         Click.x2Click = true;
         x2tick = true;
      }

    }

}
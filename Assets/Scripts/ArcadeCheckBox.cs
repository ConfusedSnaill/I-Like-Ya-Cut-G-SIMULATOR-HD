using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ArcadeCheckBox : MonoBehaviour
{
  //imageSprite is the actual image itself and boxchecked/boxunchecked are sprites for the checkbox
   public Image imageSprite;
   public Sprite boxchecked;
   public Sprite boxunchecked;

   public static bool arcadetick;
   public GameObject machine;

   public void Update()
   {

      //This makes sure the checkbox is ticked or unticked when you click it
      if(arcadetick == true)
      {
        imageSprite.sprite = boxchecked;
        machine.SetActive(true);
      }
      else
      {
        imageSprite.sprite = boxunchecked;
        machine.SetActive(false);
      }

   }

   //Used when resetting your save file
   public void ResetMachine()
   {
      machine.SetActive(false);
   }

   public void SwitchMachineCheckBox()
   {

     //Switches between being On/Off
     if(arcadetick == true)
      {
        arcadetick = false;
      }
      else
      {
        arcadetick = true;
      }

   }
   
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap : MonoBehaviour
{
   //Bounce animation for the button
   
   public Animator anim;

   public void GrowandShrink()
   {
      anim.SetBool("tapped", true);
   }

   public void StopGrowandShrink()
   {
      anim.SetBool("tapped", false);
   }
}

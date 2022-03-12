using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBonusFeature : MonoBehaviour
{
  //This is just the script that plays an animation when you unlock a reward

   public static Animator animator;

   public void Start()
   {
     animator = GetComponent<Animator>(); 
   }

   public void StopUnlockText()
   {
     animator.SetBool("appear", false);
   }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class MileStones : MonoBehaviour
{

  //Annoying bools that only exist so I can get the rewards to work with saving/loading
   public static bool reward1, reward2, reward3, reward4, reward5;

  //Rewards for getting to a certain score
   public GameObject Tickbox1, Tickbox2, Tickbox3, Tickbox4, Star1;
  
  //Music and sound effects
   public AudioSource audiosrc;
   public AudioClip rewardGet, starsound;

  //For playing an animation when you get a reward
   public Animator animator;
  
  //To make sure the animation only plays once
   public static bool playonce1, playonce2, playonce3, playonce4, playonce5;  

   public void Update()
   { 

      //First Reward (Bruh Button)//
      if (ClickableG.ScoreCount > 199)
      {
         reward1 = true;
         Tickbox1.SetActive(true);

         if(playonce1 == false)
         {
            animator.SetBool("appear",true);
            audiosrc.PlayOneShot(rewardGet);
            playonce1 = true;
         }
      }
      else
      {
         reward1 = false;
         Tickbox1.SetActive(false);
      }
      //First Reward (Bruh Button)//


      //Second Reward (Clicker X2)//
      if (ClickableG.ScoreCount > 499)
      {
         reward2 = true;
         Tickbox2.SetActive(true);

         if(playonce2 == false)
         {
           animator.SetBool("appear",true);
           audiosrc.PlayOneShot(rewardGet);
           playonce2 = true;
         }
      }
      else
      {
          reward2 = false;
          Tickbox2.SetActive(false);
      }
      //Second Reward (Clicker X2)//


      //Third Reward (Arcade Machine)//
       if (ClickableG.ScoreCount > 999)
      {
         reward3 = true;
         Tickbox3.SetActive(true);

         if(playonce3 == false)
         {
           animator.SetBool("appear",true);
           audiosrc.PlayOneShot(rewardGet);
           playonce3 = true;
         }
      }
      else
      {
          reward3 = false;
          Tickbox3.SetActive(false);
      }
      //Third Reward (Arcade Machine)//


      //Fourth Reward (Particle Effects)//
      if (ClickableG.ScoreCount > 1499)
      {
         reward4 = true;
         Tickbox4.SetActive(true);

         if(playonce4 == false)
         {
           animator.SetBool("appear",true);
           audiosrc.PlayOneShot(rewardGet);
           playonce4 = true;
         }
      }
      else
      {
         reward4 = false;
         Tickbox4.SetActive(false);
      }
      //Fourth Reward (Particle Effects)//


      //Fifth Reward (Star)//
      if (ClickableG.ScoreCount > 1999)
      {
         reward5 = true;
         Star1.SetActive(true);

         if(playonce5 == true)
         {
           animator.SetBool("appear",true);
           audiosrc.PlayOneShot(rewardGet);
           playonce5 = true;
         }
      }
      else
      {
         reward5 = false;
         Star1.SetActive(false); 
      }
      //Fifth Reward (Star)//

   }

}

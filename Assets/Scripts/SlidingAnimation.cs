using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingAnimation : MonoBehaviour
{
  //This script is for the bonus pages sliding up and down animation
  //At the end of each animation it sets a bool to either be true or false
  //so it doesn't have to be done through code

  public Animator anim;

  public void SlideIn()
  {
    anim.SetBool("Enter", true); 
  }

  public void StayIn()
  {
    anim.SetBool("Enter", false);
  }

  public void SlideOut()
  {
    anim.SetBool("Exit", true);
  }

  public void StayOut()
  {
    anim.SetBool("Exit", false);
  }

  //(theres probably a way better way of doing this but
  //this is how I'll be doing these animations for now
}

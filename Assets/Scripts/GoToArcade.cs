using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToArcade : MonoBehaviour
{
  //funny meme animation go brr

  public Animator anim;

  public void StartArcadeAnim()
  {
    //Arcade machine will strech across the screen
    anim.SetBool("PressedArcade", true);
  }

  public void StopArcadeAnim()
  {
    //When the animation ends this function will activate
    anim.SetBool("PressedArcade", false);
  }

  public void ArcadeLoad()
  {
    //Loads the arcade without the loading screen for a wierd but cool effect
    SceneManager.LoadScene(2);
  }

}

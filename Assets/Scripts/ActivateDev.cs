using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDev : MonoBehaviour
{
  //In Update 1.01 I added these Dev tools that make developing this game a lot easier
  //because I could change the score as I playtested to fix bugs and test new features
  //without having to play the entire game over and over again

  //Feel free to use them if you're modding this game!
  //(remember to to comment them out before you build it)

  public bool dev;
  public GameObject devcontrols; 

  void Update()
  {

     //Hold down F1 and tap F2 to activate the Dev Tools
     //if(Input.GetKey(KeyCode.F1) && Input.GetKeyDown(KeyCode.F2) && dev == false)
     //{
       //devcontrols.SetActive(true);
      //dev = true;

       //devcontrols.transform.SetAsLastSibling();
     //}
     //else if(Input.GetKey(KeyCode.F1) && Input.GetKeyDown(KeyCode.F2) && dev == true)
     //{       
       //devcontrols.SetActive(false);
       //dev = false;
     //}
        
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
   //I implemented a loading screen but the game runs so fast that 
   //you can only see it for about half a second

   public GameObject loadingScreen;
   public Slider slider;

   public void LoadLevel (int sceneIndex)
   {
       //This allows me to choose whichever scene I want in the Editor without 
       //having to write each level out seperately in different scripts 

       StartCoroutine(LoadAsynchronously(sceneIndex));

       //Sorry for wording that so badly I've been working on the last 
       //part of this update all night and my brain can barely function  
   }

   IEnumerator LoadAsynchronously (int sceneIndex)
   {
       AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

       loadingScreen.SetActive(true);

       while (!operation.isDone)
       {
           //Checks how much of the scene has been loaded
           float progress = Mathf.Clamp01(operation.progress / .9f);

           //Shows you a visual representaion using a slider
           slider.value = progress;
           
           yield return null;
       }
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    //Allows you to set different score values for each button
    [SerializeField]
    public int devscore;

    public void addDevscore()
    {
      //Adds the number you typed to your score when you press a button
      ClickableG.ScoreCount += devscore;
    }

    public void takeawayDevscore()
    {
      //Subtracts the number you typed to your score when you press a button
      ClickableG.ScoreCount -= devscore; 
    }

}

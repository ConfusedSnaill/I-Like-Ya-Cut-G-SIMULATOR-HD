using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ClickableG : MonoBehaviour
{
    public Animator animator;
    public TextMeshProUGUI ScoreDisplay;

    public int InternalScore;
    public static int ScoreCount;    

    void Update()
    {
        //Displays your score
        InternalScore = ScoreCount;
        ScoreDisplay.GetComponent<TextMeshProUGUI>().text = "Score: " + InternalScore;
    }

    public void SaveScore()
    {
        SaveSystem.SaveScore(this);
        animator.Play("Gone");
    }

    public void LoadScore()
    {
        SaveData data = SaveSystem.LoadScore();

        ScoreCount = data.ScoreCount;
        
        //Resets the animation that plays when you unlock a reward
        animator.Play("Gone");

        //Sets the variables after being converted back from binary 
        //(I think... this saving and loading shit is confusing af)
        MileStones.reward1 = data.reward1;
        MileStones.reward2 = data.reward2;
        MileStones.reward3 = data.reward3;
        MileStones.reward4 = data.reward4;
        MileStones.reward5 = data.reward5;

        BruhCheckBox.bruhtick = data.bruhtick;
        x2CheckBox.x2tick = data.x2tick;
        Click.x2Click = data.x2Click;
        ArcadeCheckBox.arcadetick = data.arcadetick;
        ParticleCheckbox.particletick = data.particletick;

        MileStones.playonce1 = data.playonce1;
        MileStones.playonce2 = data.playonce2;
        MileStones.playonce3 = data.playonce3;
        MileStones.playonce4 = data.playonce4;
        MileStones.playonce5 = data.playonce5;
        
    }
}

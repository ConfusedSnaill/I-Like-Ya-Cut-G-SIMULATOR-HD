using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class StartSaveFile : MonoBehaviour
{
    //I fixed an issue with the save by loading it on awake
    public ClickableG script;

    public void Awake()
    {
       script = script.GetComponent<ClickableG>();
       script.LoadScore();
    }
    
}

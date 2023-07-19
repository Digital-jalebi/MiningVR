using RanchiMusuem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public void Click(string sceneName)
    { 
        GameManager.Instance.PlayVideo(sceneName);
    }
}

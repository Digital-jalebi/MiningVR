using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyToggle : MonoBehaviour
{
    [SerializeField] private GameObject onObj;
    [SerializeField] private GameObject offObj;

    public void OnChange(bool val)
    {
        onObj.SetActive(!val);
        offObj.SetActive(val);
    }
}

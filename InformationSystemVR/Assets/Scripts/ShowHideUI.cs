using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{
    [SerializeField]
    private GameObject GlobalUIVar;

    public void showUI()
    {
       
        GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation = false;

    }
    public void hideUI()
    {
       
        GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation = true;
    }
}

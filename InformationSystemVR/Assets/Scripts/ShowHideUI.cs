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
        GeneratedGlobalUIVarObj myVariable = GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>();
        for (int x = 0; x < myVariable.objGlobal.Length; x++)
        {


            // Debug.Log($"looking at {obj.name}", this);
            for (int i = 0; i < myVariable.objGlobal[x].transform.childCount; i++)
            {

                GameObject tempo = myVariable.objGlobal[x].transform.GetChild(i).gameObject;
                Debug.Log($"looking at {tempo.name}", this);
                tempo.SetActive(true);
            }

        }

    }
    public void hideUI()
    {
       
        GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation = true;
        GeneratedGlobalUIVarObj myVariable = GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>();
        for (int x = 0; x < myVariable.objGlobal.Length; x++)
        {


            // Debug.Log($"looking at {obj.name}", this);
            for (int i = 0; i < myVariable.objGlobal[x].transform.childCount; i++)
            {

                GameObject tempo = myVariable.objGlobal[x].transform.GetChild(i).gameObject;
                Debug.Log($"looking at {tempo.name}", this);
                tempo.SetActive(false);
            }

        }
    }
}

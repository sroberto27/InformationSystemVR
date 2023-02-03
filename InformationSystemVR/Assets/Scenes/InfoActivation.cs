using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InfoActivation : MonoBehaviour
{
    public GameObject[] UI;
    [SerializeField]
    private GameObject GlobalUIVar;
    void OnTriggerEnter(Collider Obj)
    {
        if (Obj.tag == "Player" && !GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation)
        {
            for(int x=0; x< UI.Length;x++)
                UI[x].SetActive(true);
        }
    }

    void OnTriggerExit(Collider Obj)
    {
        if (Obj.tag == "Player" && !GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation)
        {
            for (int x = 0; x < UI.Length; x++)
                UI[x].SetActive(false);
        }
    }
 
}



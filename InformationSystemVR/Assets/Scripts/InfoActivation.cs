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
    }

    void OnTriggerExit(Collider Obj)
    {
        if (Obj.tag == "Player" && !GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation)
        {
            for (int x = 0; x < UI.Length; x++)
                UI[x].SetActive(false);

            GeneratedGlobalUIVarObj myVariable = GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>();
            for (int x = 0; x < myVariable.objGlobal.Length; x++)
            {

                for (int i = 0; i < myVariable.objGlobal[x].transform.childCount; i++)
                {

                    GameObject tempo = myVariable.objGlobal[x].transform.GetChild(i).gameObject;
                    // Debug.Log($"looking at {tempo.name}", this);
                    tempo.SetActive(false);
                }

            }
        }
    }
 
}



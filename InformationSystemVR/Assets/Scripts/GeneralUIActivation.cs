using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralUIActivation : MonoBehaviour
{
    [SerializeField]
    private GameObject GlobalUIVar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation)
        {
          //  Debug.Log($"UI SYSTEM IS ACTIVATED");
        }
        else
        {
          //  Debug.Log($"UI SYSTEM IS DISACTIVATED");
            GeneratedGlobalUIVarObj myVariable = GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>();
            for (int x = 0; x < myVariable.objGlobal.Length; x++)
            {

                for (int i = 0; i < myVariable.objGlobal[x].transform.childCount; i++)
                {

                    GameObject tempo = myVariable.objGlobal[x].transform.GetChild(i).gameObject;
                    tempo.SetActive(false);
                }

            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour
{
    
    public LayerMask mask;
    private float timer;
    [SerializeField]
    private GameObject GlobalUIVar;
    private bool flag;
    public float delayTime = 3;
    IEnumerator delay(int timeSec)
    {
        print(Time.time);
        yield return new WaitForSeconds(15);
        print(Time.time);
    }
    private void Update()
    {
        if (!GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>().bottonActivation) { 
        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity, mask))
        {
                if (!flag) { flag = true;
                    var obj = hit.collider.gameObject;
                    GeneratedGlobalUIVarObj myVariable = GlobalUIVar.GetComponent<GeneratedGlobalUIVarObj>();
                    for (int x = 0; x < myVariable.objGlobal.Length; x++)
                    {

                        //Debug.Log($"name of globalvar {GlobalUIVar[x].name}", this);
                        if (myVariable.objGlobal[x].name == obj.name)
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
            
        }
        else
        {
                if (flag)
                {
                    timer += Time.deltaTime;
                    
                    if (timer > delayTime)
                    {
                        Debug.Log($"INIFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDelay =  "+timer);
                        //StartCoroutine(delay(15));
                        flag = false;
                        Debug.Log($"looking at no gazable objects");
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
                        timer = 0.0f;
                    }
                    
                }
                else
                {
                    //nothing yet

                }
            
        }
    }
    }
}



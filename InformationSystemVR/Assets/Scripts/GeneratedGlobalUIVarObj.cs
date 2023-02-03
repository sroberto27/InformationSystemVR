using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedGlobalUIVarObj : MonoBehaviour
{
    public GameObject[] objGlobal;
    public bool bottonActivation;
    // Start is called before the first frame update
  

    public GameObject[] FindInGlobalUI(int layer)
    {
        List<GameObject> validTransforms = new List<GameObject>();
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].gameObject.layer == layer)
                {
                    validTransforms.Add(objs[i].gameObject);
                }
            }
        }
        return validTransforms.ToArray();
    }

    public void setGlobalUIActiveFromGazeL(bool flag)
    {
        for (int x =0; x< objGlobal.Length; x++)
        {
            for (int i = 0; i < objGlobal[x].transform.childCount; i++)
            {
               GameObject tempo = objGlobal[x].transform.GetChild(i).gameObject;
                tempo.SetActive(flag);
            }                            
        }
    }



    void Start()
    {
        bottonActivation = false;
        objGlobal = FindInGlobalUI(8);// 8 is GAze Layer
        setGlobalUIActiveFromGazeL(false);

    }

}

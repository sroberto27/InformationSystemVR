using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoActivationGaze : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    public void showINFO()
    {
        UI.SetActive(true);
        Debug.Log("It was activated  -----------");
    }

    
    
}

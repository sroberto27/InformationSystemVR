using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisActiveGaze : MonoBehaviour
{
    public GameObject UI;
    // Start is called before the first frame update
    public void hideINFO()
    {
        UI.SetActive(false);
        Debug.Log("It was Disactivated  ++++++++++");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMoreLessInfo : MonoBehaviour
{
    public bool MoreOrLEss = false;
    public GameObject MoreInfo;
    public GameObject LessInfo;

    public void showMoreInfo()
    {
        MoreOrLEss = true;
        MoreInfo.SetActive(true);
        LessInfo.SetActive(false);
    }
    public void showLessInfo()
    {
        MoreOrLEss = false;
        MoreInfo.SetActive(false);
        LessInfo.SetActive(true);
    }

}

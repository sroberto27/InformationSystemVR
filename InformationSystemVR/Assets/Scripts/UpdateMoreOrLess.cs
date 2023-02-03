using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMoreOrLess : MonoBehaviour
{

    [SerializeField]
    private GameObject GlobalMoreOrLess;
    // Update is called once per frame
    void Update()
    {
        if(GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().MoreOrLEss)
        {
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().MoreOrLEss = true;
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().MoreInfo.SetActive(true);
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().LessInfo.SetActive(false);
        }else
        {
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().MoreOrLEss = false;
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().MoreInfo.SetActive(false);
            GlobalMoreOrLess.GetComponent<ShowMoreLessInfo>().LessInfo.SetActive(true);
        }
    }
}

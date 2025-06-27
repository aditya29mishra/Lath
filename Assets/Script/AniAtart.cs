using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniAtart : MonoBehaviour
{
    public GameObject stAni;
    public GameObject ClosAni;
    public GameObject GreeBut;
    public GameObject RedButt;


    public void StAnim()
    {
        stAni.SetActive(true);
        ClosAni.SetActive(false);
        GreeBut.SetActive(false);

        Invoke("cl", 4f);
    }

    public void cl()
    {
        RedButt.SetActive(true);
    }


    public void STrev()
    {
        stAni.SetActive(false);
        ClosAni.SetActive(true);
        RedButt.SetActive(false);

        Invoke("cld", 8f);
    }

    public void cld()
    {
        GreeBut.SetActive(true);
    }

}

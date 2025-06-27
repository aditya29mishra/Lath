using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressStart : MonoBehaviour
{
    public GameObject pnlone;
    public GameObject pnlTwo;

   
    public void StrtPr()
    {
        pnlone.SetActive(false);
        pnlTwo.SetActive(true);
    }
}

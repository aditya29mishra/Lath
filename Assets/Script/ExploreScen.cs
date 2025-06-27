using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExploreScen : MonoBehaviour
{
    

    public void scnChange()
    {
        SceneManager.LoadScene("Explore");
    }


    public void AssembleScn()
    {
        SceneManager.LoadScene("CNC Module");
    }

}

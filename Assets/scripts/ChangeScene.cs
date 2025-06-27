using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SceneChangeFactoryEng()
    {
        SceneManager.LoadScene("Factory English");
    }
    public void SceneChangeFactoryHindi()
    {
        SceneManager.LoadScene("Factory Hindi");
    }
    public void SceneChangeToMainMenu()
    {
        SceneManager.LoadScene("Welcome");
    }
    public void SceneChangeToExploreEng()
    {
        SceneManager.LoadScene("explore english");
    }
    public void SceneChangeToExploreHindi()
    {
        SceneManager.LoadScene("explore hindi");
    }
    public void SceneChangeTocnc()
    {
        SceneManager.LoadScene("cnc");
    }

}

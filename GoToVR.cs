using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToVR : MonoBehaviour
{

    public void OpenAR1 ()
    {
    	SceneManager.LoadScene(1);
    }
    public void OpenAR2()
    {
        SceneManager.LoadScene(2);
    }
    public void Back ()
    {
    	SceneManager.LoadScene(0);
    }
    
}

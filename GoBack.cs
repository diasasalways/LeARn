using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public void Goback ()
    {
    	SceneManager.LoadScene(0);
    }
    public void OpenAR1 ()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenAR2()
    {
        SceneManager.LoadScene(2);
    }
    public void OpenAR3()
    {
        SceneManager.LoadScene(3);
    }
    public void Back ()
    {
        SceneManager.LoadScene(0);
    }
}

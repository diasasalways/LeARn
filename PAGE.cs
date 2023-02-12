using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAGE : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void DoTask()
    {
        SceneManager.LoadScene(1);
    }
    public void GoMain()
    {
        SceneManager.LoadScene(0);
    }
    public void GoBckAR()
    {
        SceneManager.LoadScene(3);
    }
}

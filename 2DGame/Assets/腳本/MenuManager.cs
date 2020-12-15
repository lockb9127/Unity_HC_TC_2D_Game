using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void invokeopen()
    {
        invoke("open", 1);
    }
    public void open()
    {
        SceneManager.LoadScene("遊戲場景");
    }
    public void invokeleave()
    {
        invoke("leave", 1);
    }
    public void leave()
    {
        Application.Quit();
    }
}


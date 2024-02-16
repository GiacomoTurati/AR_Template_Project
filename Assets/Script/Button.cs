using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string SceneName = "";
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
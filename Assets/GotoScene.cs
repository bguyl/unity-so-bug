using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoScene : MonoBehaviour
{
    public void GoTo(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

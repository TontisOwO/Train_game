using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField] string SceneName;

    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
}

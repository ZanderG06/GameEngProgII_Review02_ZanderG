using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
    }

    public void OpenScene(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{
    private static string loadedScene;
    private Button button;
    // Start is called before the first frame update

    public void LoadScene(string sceneName)
    {
        loadedScene = sceneName;
        SceneManager.LoadScene(loadedScene);
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneClick : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 10f;
    [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;

   
    private void ButtonClick()
    {
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
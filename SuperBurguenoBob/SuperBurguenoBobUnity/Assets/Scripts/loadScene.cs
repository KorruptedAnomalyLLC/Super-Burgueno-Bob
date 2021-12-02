
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    [SerializeField] private float delayBeforeLoading = 10f;
    [SerializeField] private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    private void ButtonClick()
    {
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
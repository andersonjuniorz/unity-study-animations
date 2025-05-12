using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    [SerializeField] private float delay = 10f;
    [SerializeField] private string sceneName = "MainMenu";

    private void Start() => StartCoroutine(WaitAndReturn());

    private System.Collections.IEnumerator WaitAndReturn()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}

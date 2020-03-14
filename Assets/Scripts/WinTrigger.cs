using UnityEngine.SceneManagement;
using UnityEngine;
public class WinTrigger : MonoBehaviour
{
    [SerializeField] string nextLevelName;
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
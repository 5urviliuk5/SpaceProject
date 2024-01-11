using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

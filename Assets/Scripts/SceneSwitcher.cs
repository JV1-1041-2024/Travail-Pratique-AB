using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // This method loads the Chambre scene
    public void LoadChambreScene()
    {
        // Check if the scene is available in the build settings
        if (Application.CanStreamedLevelBeLoaded("Chambre"))
        {
            SceneManager.LoadScene("Chambre");
        }
        else
        {
            Debug.LogError("Scene 'Chambre' could not be found in build settings!");
        }
    }
}
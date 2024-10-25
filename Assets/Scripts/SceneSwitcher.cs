using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // This method loads a specified scene
    public void LoadScene(string sceneName)
    {
        // Check if the scene is available in the build settings
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' could not be found in build settings!");
        }
    }

    // Method to load the Chambre scene
    public void LoadChambreScene()
    {
        LoadScene("Chambre");
    }

    // Method to load the Salon scene
    public void LoadSalonScene()
    {
        LoadScene("Salon");
    }

    // Method to load the Salle de bain scene
    public void LoadSalleDeBainScene()
    {
        LoadScene("Salle de bain");
    }
}

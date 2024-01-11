using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneBtn : MonoBehaviour
{
    public Button myButton;  // Attach your button in the Unity Editor
    public string sceneName = "YourSceneName";  // Specify your scene name in the Unity Editor

    private void Start()
    {
        // Make sure the button is not null
        if (myButton != null)
        {
            // Attach the method to the button click event
            myButton.onClick.AddListener(ChangeSceneOnClick);
        }
        else
        {
            Debug.LogError("Button not assigned to the script!");
        }
    }

    // Method to be called when the button is clicked
    private void ChangeSceneOnClick()
    {
        // Check if the specified scene name is not empty or null
        if (!string.IsNullOrEmpty(sceneName))
        {
            // Change the scene
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not specified!");
        }
    }



}

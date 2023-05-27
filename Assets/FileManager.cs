using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class FileSelection : MonoBehaviour
{
    public Button fileSelectButton;
    private string selectedFilePath;

    public void Start()
    {
        Button btn = fileSelectButton.GetComponent<Button>();
        btn.onClick.AddListener(OpenFileExplorer);
    }

    private void OpenFileExplorer()
    {
        string fileExtension = "png"; // Specify the file extension you want to filter by

        string filePath = EditorUtility.OpenFilePanel("Select a file", "", fileExtension);

        if (!string.IsNullOrEmpty(filePath))
        {
            selectedFilePath = filePath;
            Debug.Log("Selected File: " + selectedFilePath);
        }
        else
        {
            Debug.Log("No file selected.");
        }
    }
}
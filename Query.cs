using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase;
using Firebase.Extensions;
using Firebase.Storage;

public class Query: MonoBehaviour
{
    FirebaseStorage storage;
    StorageReference storageReference;
    public Text inputField;
    public InputField textDisplay;
    
    public void search()
    {
        name = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = name; 
        storage = FirebaseStorage.DefaultInstance;
        storageReference = storage.GetReferenceFromUrl("gs://learn-650e0.appspot.com");                  
        if (storage.GetReferenceFromUrl($"gs://learn-650e0.appspot.com/") == null)
             Debug.Log("File Not Exist");
        else
             Debug.Log("File Exists");

    }
}

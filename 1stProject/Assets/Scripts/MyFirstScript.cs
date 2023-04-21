using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyFirstScript : MonoBehaviour
{
    public Button button;
    public string newScene;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(onButtonclick);
    }
    private void onButtonclick()
    {
        Debug.Log("BUtton clicked");
        SceneManager.LoadScene(newScene);
    }

}

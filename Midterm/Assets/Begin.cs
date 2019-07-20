using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour
{
    public string level;
    // Start is called before the first frame update
    public void loadScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}

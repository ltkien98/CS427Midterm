using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public void Start()
    {
        
    }
    public void Update()
    {
        OpenPanel();    
    }
    public void OpenPanel()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (Panel != null)
            {
                Panel.SetActive(true);
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            Panel.SetActive(false);
        }
        
    }
}

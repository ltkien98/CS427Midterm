using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint1 : MonoBehaviour
{
    public GameObject Panel;
    bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (check == false)
            {
                Panel.SetActive(true);
                check = true;
            }
            else
            {
                Panel.SetActive(false);
                check = false;
            }
        }
    }
   
}

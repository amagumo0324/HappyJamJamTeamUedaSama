using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Player : MonoBehaviour
{
    //
    GameObject T_safe;
    GameObject T_out;

    // Start is called before the first frame update
    void Start()
    {
        T_safe = GameObject.FindWithTag("");
    }

    // Update is called once per frame
    void Update()
    {
        //マウス右クリック
        if(Input.GetMouseButtonDown(1))
        {

        }
        //マウス左クリック
        else if(Input.GetMouseButtonDown(0))
        {

        }

    }
}

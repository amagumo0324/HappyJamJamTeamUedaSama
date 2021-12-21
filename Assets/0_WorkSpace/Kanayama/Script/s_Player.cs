using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Player : MonoBehaviour
{
    //tag受け取り用変数
    GameObject T_safe;
    GameObject T_out;

    enum Check
    {
        Null,
        Safe,
        Out
    };

    Check check;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //tag確認
        if (collision.tag == "safe")
        {

        }
        else if(collision.tag == "out")
        {

        }
      
    }

    // Update is called once per frame
    void Update()
    {

        //マウス右クリック
        if(Input.GetMouseButtonDown(1) && check == Check.Null)
        {
            check = Check.Safe;
        }
        //マウス左クリック
        if(Input.GetMouseButtonDown(0) && check == Check.Null)
        {
            check = Check.Out;
        }
        else
        {
            check = Check.Null;
        }

    }

}

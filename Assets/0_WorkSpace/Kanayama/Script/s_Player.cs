using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Player : MonoBehaviour
{
    //tag�󂯎��p�ϐ�
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
        //tag�m�F
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

        //�}�E�X�E�N���b�N
        if(Input.GetMouseButtonDown(1) && check == Check.Null)
        {
            check = Check.Safe;
        }
        //�}�E�X���N���b�N
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

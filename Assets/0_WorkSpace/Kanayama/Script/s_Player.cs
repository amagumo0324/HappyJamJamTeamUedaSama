using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_Player : MonoBehaviour
{
    //tag�󂯎��p�ϐ�

    enum Check
    {
        Null,
        Success,
        Out
    };

    Check check;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(check == Check.Null)
        {
            //tag�m�F
            if (collision.tag == "safe")
            {
                //�}�E�X�E�N���b�N�Ő���
                if (Input.GetMouseButtonDown(1))
                {
                    check = Check.Success;
                    Debug.Log("����");
                    check = Check.Null;
                }
                else if(Input.GetMouseButtonDown(0))
                {
                    check = Check.Out;
                    Debug.Log("���s");
                    check = Check.Null;
                }
                
            }
            else if(collision.tag == "out")
            {
                //�}�E�X���N���b�N�Ő���
                if (Input.GetMouseButtonDown(0))
                {
                    check = Check.Success;
                    Debug.Log("����");
                    check = Check.Null;
                }
                if (Input.GetMouseButtonDown(1))
                {
                    check = Check.Out;
                    Debug.Log("���s");
                    check = Check.Null;
                }
            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
    }

}

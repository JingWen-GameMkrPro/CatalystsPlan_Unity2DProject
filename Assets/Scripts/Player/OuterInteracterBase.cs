using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Actor�~�b���gBase: �Ҧ����⤧�����Ҧ����ʦ欰���b�o��
public abstract class OuterInteracterBase : MonoBehaviour
{
    //�ۤv����
    GameObject Causer;

    private void Start()
    {
        Causer = transform.root.gameObject;
    }

    //����
    public virtual void ReduceHP(GameObject causer, float value) { }


}

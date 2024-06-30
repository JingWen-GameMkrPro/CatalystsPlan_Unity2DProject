using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDatabase : MonoBehaviour
{
    [HideInInspector]
    public SD_MonsterAtt.Data MonsterAtt;

    [HideInInspector]
    public int BeDamagedRecordValue = 0;

    //���ʤ���A�ݭn�հʪ��p�H��������
    [SerializeField]
    public SD_MonsterAtt SDMonsterAtt; //ĵ�i�G���n�ק惡�ܼơA�o�|�ɭP��l��ƳQ���
    public Rigidbody2D RB;
    public DetecterManager DetecterManager;


    public bool isAntiMode = false;
    void Start()
    {
        checkSerializeField();

        //���o���O������Ƶ��c�ƥ�
        MonsterAtt = SDMonsterAtt.data;
    }

    //�T�{SerializeField�ŭ�
    private void checkSerializeField()
    {
        if (SDMonsterAtt == null)
        {
            Debug.LogError("SD_MonsterAtt == null");
        }

        if (RB == null)
        {
            Debug.LogError("Rigidbody2D == null");
        }

        if (DetecterManager == null)
        {
            Debug.LogError("DetecterManager == null");
        }
    }
}

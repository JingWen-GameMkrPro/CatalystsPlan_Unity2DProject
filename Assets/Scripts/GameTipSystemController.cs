using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTipSystemController : MonoBehaviour
{

    private void Start()
    {
        
    }

    /// <summary>
    /// �H�U���~�ɥi�H�I�s��API
    /// </summary>
    /// <param name="text">���ܰT��</param>
    /// <param name="continueSecond">���򪺬��</param>
    /// <param name="canBeOverride">�����ɶ��������A�|���|�Q�s���T���л\</param>
    public void ShowTip(string text, float continueSecond, bool canBeOverride)
    {
        //��I�s���禡�ɡA�N�|��ܴ��ܰT���ت��� (���ӳ]�wvisible�A���n�]�wactive�A�o�|�ϸ}���L�k�B�@)
        //���ɱN�|�i�J�˼ƭp�ɡA�ɶ�������N�|���s���ô��ܰT���ءAunity�p�ɥ\��аѾ\ corountine
        //�z�i�H²��ۦ�b�o�䪺Start()�I�s���禡�A�ݬݬO�_�i�H�X�{��r�æb�ɶ�������
    }
}

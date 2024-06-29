using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTipSystemController : MonoBehaviour
{
    /// <summary>
    /// �H�U���~�ɥi�H�I�s��API
    /// </summary>
    /// <param name="text">���ܰT��</param>
    /// <param name="continueSecond">���򪺬��</param>
    /// <param name="canBeOverride">�����ɶ��������A�|���|�Q�s���T���л\</param>

    public TMP_Text tiptext;
    private float continueSecond = 3.0f;
    private float timer;
    private bool canBeOverride = false;

    private void Start()
    {

       

    }



    public void ShowTip(string text, float duration, bool canBeOverride)
    {
        // ��I�s���禡�ɡA�N�|��ܴ��ܰT���ت��� (���ӳ]�wvisible�A���n�]�wactive�A�o�|�ϸ}���L�k�B�@)
        // ���ɱN�|�i�J�˼ƭp�ɡA�ɶ�������N�|���s���ô��ܰT���ءAunity�p�ɥ\��аѾ\ coroutine
        // �z�i�H²��ۦ�b�o�䪺 Start() �I�s���禡�A�ݬݬO�_�i�H�X�{��r�æb�ɶ�������

        tiptext.text = text;
        tiptext.gameObject.SetActive(true);

        this.continueSecond = duration;
        this.canBeOverride = canBeOverride;

        if (canBeOverride)
        {
            StopAllCoroutines();
            timer = 0;
        }

    }

    private void Update()
    {
        if (tiptext.gameObject.activeSelf && canBeOverride)
        {
            timer += Time.deltaTime;
            if (timer >= continueSecond)
            {
                tiptext.gameObject.SetActive(false);
                timer = 0;
            }
        }
    }
}
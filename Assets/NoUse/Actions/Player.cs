using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// ���a�ͩR�t��
    /// </summary>
    private HealthSystem _healthSystem;

    void Awake()
    {
        // ������� HealthSystem �ե�
        _healthSystem = GetComponent<HealthSystem>();

        // �p�G _healthSystem �� null�A��X���~�T��
        if (_healthSystem == null)
        {
            Debug.LogError("HealthSystem component not found on the player object.");
        }
    }

    // ���a�P��L��H�o�͸I���ɽե�
    void OnCollisionEnter(Collision collision)
    {
        // �ˬd�I������H�O�_�O�p�ǡ]���]�p�Ǧ��@�Ӽ��� "Enemy"�^
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (_healthSystem != null)
            {
                // �缾�a�y���ˮ`�A�o�̰��]�p�ǨC���I���y�� 1 �I�ˮ`
                _healthSystem.Damage(1);
            }
        }
    }
}

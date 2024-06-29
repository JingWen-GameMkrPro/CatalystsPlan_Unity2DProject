using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    // ����ͩR��
    private Slider _healthSlider;

    /// <summary>
    /// �ͩR��
    /// </summary>
    public float Health
    {
        get
        {
            return _healthSlider != null ? _healthSlider.value : 0;
        }

        set
        {
            if (_healthSlider != null)
            {
                _healthSlider.value = Mathf.Clamp(value, 0, _healthSlider.maxValue);
            }
        }
    }

    private void Start()
    {
        if (_healthSlider == null)
        {
            Debug.LogError("Health slider is not assigned!");
        }
    }

    /// <summary>
    /// �ˮ`
    /// </summary>
    /// <param name="value">�ˮ`��</param>
    public void Damage(float value)
    {
        if (_healthSlider != null)
        {
            Health -= value;
        }
    }

    /// <summary>
    /// �v��
    /// </summary>
    /// <param name="value">�v����</param>
    public void Heal(float value)
    {
        if (_healthSlider != null)
        {
            Health += value;
        }
    }

    /// <summary>
    /// ������_
    /// </summary>
    public void RecoverFully()
    {
        if (_healthSlider != null)
        {
            Health = _healthSlider.maxValue;
        }
    }
}
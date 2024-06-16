using System;
using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "SD_PlayerAtt", menuName = "ScriptableObjects/PlayerAtt", order = 1)]
public class SD_PlayerAtt : ScriptableObject
{
    [Serializable]
    public struct Data
    {
        [Header("��q")]
        public float HP;
        public float MaxHP;

        [Header("�������ʳt��")]
        public float HorizontalSpeed;
        public float HorizontalAcceleration;

        [Header("�������ʳt���v��")]
        public float SpeedWeight;
        public float MaxSpeedWeight;

        [Header("���D")]
        public float JumpHeight;
        public float JumpToPeakTime;

        [HideInInspector]
        public float JumpStartVelocity;

    }

    public Data data = new();
}

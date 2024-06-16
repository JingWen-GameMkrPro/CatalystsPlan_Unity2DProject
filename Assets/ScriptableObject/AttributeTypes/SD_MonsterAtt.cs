using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SD_MonsterAtt", menuName = "ScriptableObjects/MonsterAtt", order = 2)]

public class SD_MonsterAtt : ScriptableObject
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

    [SerializeField]
    public Data data = new();
}

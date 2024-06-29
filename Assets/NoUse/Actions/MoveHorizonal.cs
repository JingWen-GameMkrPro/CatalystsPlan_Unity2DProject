using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;
using System;

[System.Serializable]
public class MoveHorizonal : ActionNode
{
    public enum EnumMoveDirection
    {
        Right,
        Left,
        Random
    }
    //���ʤ�V
    public NodeProperty<EnumMoveDirection> MoveDirection;

    //���ʳt��(Second)
    public NodeProperty<float> MoveSpeed;

    //���ʮɶ�(Second)
    public NodeProperty<float> MoveDuration;
    
    private float moveTime = 0;
    private GameObject go;
    private Rigidbody2D rb;

    //Test
    //public BehaviourTreeInstance behaviourTreeInstance;
    protected override void OnStart() 
    {
        //Initial
        go = blackboard.Find<GameObject>("RefPlayer").value;
        rb = go.GetComponent<Rigidbody2D>();

        //���`�P�_�B�z
        if (MoveSpeed.Value <= 0)
        {
            Debug.LogError("MoveSpeed<=0");
        }
    }

    protected override void OnStop() 
    {
        
    }

    protected override State OnUpdate() 
    {
        if (moveTime >= MoveDuration.Value)
        {
            Debug.Log("Success");
            return State.Success;
        }
        else
        {
            doTask();
        }

        return State.Running;
    }

    void doTask()
    {
        //Debug.Log("Running" + moveTime);
        //Debug.Log(message);
        //go.transform.position = Vector3.MoveTowards(go.transform.position, new Vector3(go.transform.position.x + 10, go.transform.position.y, go.transform.position.z), MoveSpeed.Value * Time.deltaTime);
        //rb.velocity = new Vector2(10 * MoveSpeed.Value, rb.velocity.y);
        moveTime = moveTime + Time.deltaTime;
    }
}

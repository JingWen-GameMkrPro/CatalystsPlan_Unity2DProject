using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;
using System.Threading;

[System.Serializable]
public class BTA_DetectEnemy : ActionNode
{
    private MonsterDatabase database;

    protected override void OnStart() 
    {
        database =  blackboard.Find<MonsterDatabase>("Database").value;
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() 
    {
        if (database.DetecterManager.DetecterRecorderList.ContainsKey("PatrolDetecter"))
        {
            if(database.DetecterManager.DetecterRecorderList["PatrolDetecter"].Count!=0)
            {
                return State.Success;
            }
            else
            {
                Debug.Log("Waitning for Enemy");
                return State.Failure;
            }
        }
        else
        {
            Debug.Log("Waitning for Enemyy");
            return State.Failure;
        }
        
    }
}

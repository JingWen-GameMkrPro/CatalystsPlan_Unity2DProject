using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMonsterController : MonoBehaviour
{
    private GameObject playerObject;

    private void Start()
    {
        //��������o���a����T��
        playerObject = getPlayerObject();

    }

    private void FixedUpdate()
    {
        
    }


    private GameObject getPlayerObject()
    {
        return GameObject.Find("Character_Main"); ;
    }

    private void horizontalMove()
    {

    }


}

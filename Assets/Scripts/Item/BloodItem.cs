using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class = �c�l���]�p��
public class BloodItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.root.gameObject.CompareTag("Player"))
        {
            Debug.Log("�}�l�^��");
            GameObject playerObject = collision.transform.root.gameObject;

            GameMaster.Instance.OuterInteracterPlayer.AddHP(this.transform.gameObject, 5f);
        }
    }
    
}


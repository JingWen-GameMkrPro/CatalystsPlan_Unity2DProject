using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // �b�I���}�l�ɳQ�ե�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ˬd�I������H�O�_�O�p��
        if (collision.gameObject.CompareTag("Monster"))
        {
            // �b����x����X�I���ƥ�
            Debug.Log("Player collided with monster!");

            // �b�o�̥i�H����P�I���������ާ@�A�Ҧp�缾�a�y���ˮ`�B���񭵮ĵ���
        }
    }
}

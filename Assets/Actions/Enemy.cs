using UnityEngine;

public class Enemy : MonoBehaviour
{
    // �b�I���}�l�ɳQ�ե�
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ˬd�I������H�O�_�O���a
        if (collision.gameObject.CompareTag("Player"))
        {
            // �b����x����X�I���ƥ�
            Debug.Log("Enemy collided with player!");

            // �p�G���a���W�� HealthSystem �}���A���y���ˮ`
            HealthSystem playerHealth = collision.gameObject.GetComponent<HealthSystem>();
            if (playerHealth != null)
            {
                // �缾�a�y���ˮ`
                playerHealth.Damage(1);
            }
        }
    }
}

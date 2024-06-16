using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static OldPlayerController;

public class InnerInteracterPlayer : MonoBehaviour
{
    [SerializeField]
    PlayerDatabase PlayerDatabase;

    [HideInInspector]
    public GameObject Causer;

    private void Start()
    {
        checkSerializeField();

        Causer = transform.root.gameObject;
    }

    //�T�{SerializeField�ŭ�
    private void checkSerializeField()
    {
        if (PlayerDatabase == null)
        {
            Debug.LogError("PlayerDatabase == null");
        }
    }

    private void Update()
    {
        checkGrounded();

        updateaAnimatorState();

        receiveInput();
    }

    private void receiveInput()
    {
        //���ʿ�J
        tryHorizontalMove();

        //���D��J�A�p�GisGrounded = 1�~��
        if (Input.GetKeyDown(KeyCode.W))
        {
            tryJump();
        }

        //������J
        if (Input.GetKeyDown(KeyCode.J))
        {
            tryAttack();
        }

        //���m��J
        if (Input.GetKeyDown(KeyCode.K))
        {
            tryDefense();
        }

        //�l���J
        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Whatever, true, 0.5f);
        }

        //�p�^�U�vLightning��J
        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Lightning, true, 0.5f);
        }

        //�������RAreaAttack��J
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.AreaAttack, true, 0.5f);
        }

        //���hDismiss��J
        if (Input.GetKeyDown(KeyCode.O))
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Dismiss, true, 0.5f);
        }
        
        //������Flash��J
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Flash, true, 0.5f);
        }
    }

    private void tryHorizontalMove()
    {
        if (!PlayerDatabase.HasPermission(PlayerDatabase.PlayerPermission.CanMove))
        {
            return;
        }

        //����첾
        var horizontalInput = Input.GetAxis("Horizontal");
        horizontalInput = Math.Clamp(horizontalInput * PlayerDatabase.PlayerAtt.HorizontalAcceleration, -1, 1);
        PlayerDatabase.RB.velocity = new Vector2(horizontalInput * PlayerDatabase.PlayerAtt.HorizontalSpeed, PlayerDatabase.RB.velocity.y);

        //�����V
        if (PlayerDatabase.RB.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (PlayerDatabase.RB.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        //����ʵe���A
        if (horizontalInput == 0)
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Moving, false);
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Idle, true);
        }
        else
        {
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Moving, true);
            PlayerDatabase.SetState(PlayerDatabase.PlayerState.Idle, false);
        }
    }

    private void tryJump()
    {
        if(!PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Grounding) || !PlayerDatabase.HasPermission(PlayerDatabase.PlayerPermission.CanJump))
        {
            return;
        }

        PlayerDatabase.RB.velocity = new Vector2(PlayerDatabase.RB.velocity.x, PlayerDatabase.PlayerAtt.JumpStartVelocity);
    }

    private void tryAttack()
    {
        if(PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Attacking) || !PlayerDatabase.HasPermission(PlayerDatabase.PlayerPermission.CanAttack))
        {
            return;
        }

        PlayerDatabase.SetState(PlayerDatabase.PlayerState.Attacking, true, 0.2f);

        if(PlayerDatabase.DetecterManager.DetecterRecorderList.ContainsKey("AttackDetecter"))
        {
            foreach(var target in PlayerDatabase.DetecterManager.DetecterRecorderList["AttackDetecter"])
            {
                target.ReduceHP(Causer, 10);
            }
        }
    }

    private void tryDefense()
    {
        if (PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Defensing) || !PlayerDatabase.HasPermission(PlayerDatabase.PlayerPermission.CanDefense))
        {
            return;
        }

        PlayerDatabase.SetState(PlayerDatabase.PlayerState.Defensing, true, 0.5f);

    }

    private void checkGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, LayerMask.GetMask("Map"));
        //�@���a�O�N�n���٨��A�קK��z
        if (!PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Grounding) && hit.collider != null)
        {
            PlayerDatabase.RB.velocity = new Vector2(PlayerDatabase.RB.velocity.x, 0);
        }
        PlayerDatabase.SetState(PlayerDatabase.PlayerState.Grounding, hit.collider != null);
    }

    private void updateaAnimatorState()
    {
        PlayerDatabase.Animator.SetBool("isJumping", !PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Grounding));
        PlayerDatabase.Animator.SetFloat("xSpeed", Math.Abs(PlayerDatabase.RB.velocity.x));
        PlayerDatabase.Animator.SetBool("isAttacking", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Attacking));
        PlayerDatabase.Animator.SetBool("isDefensing", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Defensing));
        PlayerDatabase.Animator.SetBool("isWhatever", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Whatever));
        PlayerDatabase.Animator.SetBool("isLightning", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Lightning));
        PlayerDatabase.Animator.SetBool("isAreaAttack", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.AreaAttack));
        PlayerDatabase.Animator.SetBool("isDismiss", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Dismiss));
        PlayerDatabase.Animator.SetBool("isFlash", PlayerDatabase.IsInState(PlayerDatabase.PlayerState.Flash));
    }


}

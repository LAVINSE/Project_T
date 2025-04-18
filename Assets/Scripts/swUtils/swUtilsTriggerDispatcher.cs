using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwUtilsTriggerDispatcher : MonoBehaviour
{
    #region ������Ƽ
    public System.Action<SwUtilsTriggerDispatcher, Collider> EnterCallback { get; set; } = null;
    public System.Action<SwUtilsTriggerDispatcher, Collider> StayCallback { get; set; } = null;
    public System.Action<SwUtilsTriggerDispatcher, Collider> ExitCallback { get; set; } = null;

    public System.Action<SwUtilsTriggerDispatcher, Collider2D> Enter2DCallback { get; set; } = null;
    public System.Action<SwUtilsTriggerDispatcher, Collider2D> Stay2DCallback { get; set; } = null;
    public System.Action<SwUtilsTriggerDispatcher, Collider2D> Exit2DCallback { get; set; } = null;
    #endregion // ������Ƽ

    #region �Լ�
    /** ������ ���� �Ǿ��� ��� */
    public void OnTriggerEnter(Collider collider)
    {
        this.EnterCallback?.Invoke(this, collider);
    }

    /** ������ ���� �� �� ��� */
    public void OnTriggerStay(Collider collider)
    {
        this.StayCallback?.Invoke(this, collider);
    }

    /** ������ ���� �Ǿ��� ��� */
    public void OnTriggerExit(Collider collider)
    {
        this.ExitCallback?.Invoke(this, collider);
    }

    /** ������ ���� �Ǿ��� ��� */
    public void OnTriggerEnter2D(Collider2D collider2D)
    {
        this.Enter2DCallback?.Invoke(this, collider2D);
    }

    /** ������ ���� �� �� ��� */
    public void OnTriggerStay2D(Collider2D collider2D)
    {
        this.Stay2DCallback?.Invoke(this, collider2D);
    }

    /** ������ ���� �Ǿ��� ��� */
    public void OnTriggerExit2D(Collider2D collider2D)
    {
        this.Exit2DCallback?.Invoke(this, collider2D);
    }
    #endregion // �Լ�
}

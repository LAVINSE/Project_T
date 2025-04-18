using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public static class Resolution
{
    #region Ŭ���� ������Ƽ
    public static float ScreenWidth
    {
        get
        {
#if UNITY_EDITOR
            return Camera.main.pixelWidth;
#else
			return Screen.width;
#endif // #if UNITY_EDITOR
        }
    }

    public static float ScreenHeight
    {
        get
        {
#if UNITY_EDITOR
            return Camera.main.pixelHeight;
#else
			return Screen.height;
#endif // #if UNITY_EDITOR
        }
    }

    public static Vector3 ScreenSize => new Vector3(ScreenWidth, ScreenHeight, 0.0f);
    #endregion // Ŭ���� ������Ƽ

    #region Ŭ���� �Լ�
    /** �ػ� �ʺ� ��ȯ�Ѵ� */
    public static float GetResolutionWidth(Vector3 scale)
    {
        float fAspect = scale.x / scale.y;
        return ScreenHeight * fAspect;
    }

    /** �ػ� ������ ��ȯ�Ѵ� */
    public static float GetResolutionScale(Vector3 scale)
    {
        float fScreenWidth = GetResolutionWidth(scale);
        return fScreenWidth.ExIsLessEquals(ScreenWidth) ? 1.0f : ScreenWidth / fScreenWidth;
    }
    #endregion // Ŭ���� �Լ�
}

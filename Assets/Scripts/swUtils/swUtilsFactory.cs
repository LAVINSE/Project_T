using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwUtilsFactory : MonoBehaviour
{
    #region �Լ�
    /** ���� ��ü�� �����Ѵ� */
    public static GameObject CreateGameObj(string objName,
        GameObject parentObj, Vector3 pos, Vector3 scale, Vector3 rotate,
        bool isStayWorldPos = false)
    {
        var oGameObj = new GameObject(objName);
        oGameObj.transform.SetParent(parentObj?.transform, isStayWorldPos);

        oGameObj.transform.localScale = scale;
        oGameObj.transform.localPosition = pos;
        oGameObj.transform.localEulerAngles = rotate;

        return oGameObj;
    }

    /** �纻 ���� ��ü�� �����Ѵ� */
    public static GameObject CreateCloneGameObj(string objName,
        GameObject prefabObj, GameObject parentObj, Vector3 pos,
        Vector3 scale, Vector3 rotate, bool isStayWorldPos = false)
    {
        var oGameObj = GameObject.Instantiate(prefabObj, Vector3.zero, Quaternion.identity);
        oGameObj.name = objName;
        oGameObj.transform.SetParent(parentObj?.transform, isStayWorldPos);

        oGameObj.transform.localScale = scale;
        oGameObj.transform.localPosition = pos;
        oGameObj.transform.localEulerAngles = rotate;

        return oGameObj;
    }

    /** ���� ��ü�� �����Ѵ� */
    public static T CreateGameObj<T>(string objName,
        GameObject parentObj, Vector3 pos, Vector3 scale, Vector3 rotate,
        bool isStayWorldPos = false) where T : Component
    {
        var oGameObject = SwUtilsFactory.CreateGameObj(objName,
            parentObj, pos, scale, rotate, isStayWorldPos);

        return oGameObject.GetComponent<T>() ?? oGameObject.AddComponent<T>();
    }

    /** �纻 ���� ��ü�� �����Ѵ� */
    public static T CreateCloneGameObj<T>(string objName,
        GameObject prefabObj, GameObject parentObj, Vector3 pos,
        Vector3 scale, Vector3 rotate,
        bool isStayWorldPos = false) where T : Component
    {
        var oGameObject = SwUtilsFactory.CreateCloneGameObj(objName,
            prefabObj, parentObj, pos, scale, rotate, isStayWorldPos);

        return oGameObject.GetComponent<T>() ?? oGameObject.AddComponent<T>();
    }
    #endregion // �Լ�
}

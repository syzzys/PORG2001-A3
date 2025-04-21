using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private float scaleMultiplier = 1.5f;

    public void ScaleUp()
    {
        if (targetObject != null)
        {
            targetObject.transform.localScale *= scaleMultiplier;
            targetObject.transform.position += new Vector3(0, targetObject.transform.localScale.y * scaleMultiplier * 2, 0);
        }
        else
        {
            Debug.LogWarning("target object is null!");
        }
    }

    public void ScaleDown()
    {
        if (targetObject != null)
        {
            targetObject.transform.localScale /= scaleMultiplier;
            targetObject.transform.position -= new Vector3(0, targetObject.transform.localScale.y * scaleMultiplier * 2, 0);
        }
        else
        {
            Debug.LogWarning("target object is null!");
        }
    }

    public void RotateRight()
    {
        targetObject.transform.Rotate(Vector3.up, 30f);
    }

    public void RotateLeft()
    {
        targetObject.transform.Rotate(Vector3.up, -30f);
    }

    public void MoveRight()
    {
        targetObject.transform.position += Vector3.right * 1f;
    }

    public void MoveLeft()
    {
        targetObject.transform.position += Vector3.left * 1f;
    }
}

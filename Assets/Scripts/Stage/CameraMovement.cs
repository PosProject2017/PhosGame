using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraMovement : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void TransitionCamera(Vector3 dst)
    {
        dst = new Vector3(dst.x, transform.position.y, dst.z);
        transform.DOLocalMove(dst, 0.2f).SetEase(Ease.InOutQuart);
    }
}

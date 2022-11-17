using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Burger : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    Vector3 rotation = new Vector3(0, 180, 0);

   
    private void Start()
    {
        Sequence mySequence = DOTween.Sequence();

        mySequence.Append(rb.transform.DOMove(new Vector3(1000, 10, 0), 100f, false).SetEase(Ease.InCirc));

        mySequence.Append(rb.transform.DORotate(rotation, 1f));

        mySequence.PrependInterval(1f);
    }

}

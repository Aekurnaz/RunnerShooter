using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeHorizontal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HorizontalMovement();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void HorizontalMovement()
    {
        transform.DOMoveX(2f, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);

    }
}

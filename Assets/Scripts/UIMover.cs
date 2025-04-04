using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIMover : MonoBehaviour
{
    private RectTransform _rt;
    public GameObject UIElement;

    // Start is called before the first frame update
    void Start()
    {
        _rt = GetComponent<RectTransform>();
        Vector3 targetPos = _rt.localPosition;
        _rt.localPosition = new Vector3(targetPos.x, -Screen.height, targetPos.z);
        
        if (UIElement.activeInHierarchy)
        {
            _rt.DOLocalMoveY(targetPos.y, .2f).SetEase(Ease.OutBounce);
        }
    }
}

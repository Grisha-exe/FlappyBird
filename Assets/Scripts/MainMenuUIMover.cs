using DG.Tweening;
using UnityEngine;

public class MainMenuUIMover : MonoBehaviour
{
    private Vector2 _startPosition = new Vector2(0, 1000);
    private Vector2 _endPosition;
    
    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        _endPosition = _rectTransform.anchoredPosition;
        _rectTransform.anchoredPosition = _startPosition;
    }

    public void Move()
    {
        _rectTransform.DOAnchorPos(_endPosition, 1.5f);
    }

    public void Removing()
    {
        _rectTransform.DOAnchorPos(_startPosition, 1.5f);
    }
}

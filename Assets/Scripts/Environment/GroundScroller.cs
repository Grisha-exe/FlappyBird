using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private Material _material;
    private Vector2 _offset;
    
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<Renderer>().material;
        _offset = new Vector2(scrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        _material.mainTextureOffset += _offset * Time.deltaTime;
    }
}

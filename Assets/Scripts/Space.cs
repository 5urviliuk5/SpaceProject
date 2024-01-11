using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class Space : MonoBehaviour
{
    public float speed = 0.3f;
    private MeshRenderer meshRenderer;
    private float xScroll;

    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        xScroll = Time.time * speed;

        Vector2 offset = new Vector2(xScroll, 0f);
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset); // _MainTex
    }

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
}

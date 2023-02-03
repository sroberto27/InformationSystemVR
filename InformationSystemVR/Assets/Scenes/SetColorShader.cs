using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorShader : MonoBehaviour
{
    [SerializeField]
    public Color setColor;
    public GameObject terrain;
    void Start()
    {
        Material myMaterial = GetComponent<Renderer>().material;

        myMaterial.SetColor("_AreaColor", setColor);
    }
}
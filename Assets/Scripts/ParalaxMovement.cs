using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxMovement : MonoBehaviour
{
    private MeshRenderer meshR;
    public float backgroundSpeed = 1f;
    private void Awake()
    {
        meshR = GetComponent<MeshRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        meshR.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
}

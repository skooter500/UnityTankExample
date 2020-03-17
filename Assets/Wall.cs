using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int width;
    public int height;
    // Start is called before the first frame update
    void Start()
    {
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 pos = new Vector3(col, row, 0);
                pos = transform.TransformPoint(pos);
                cube.transform.position = pos;
                cube.transform.rotation = transform.rotation;
                cube.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 1);
                cube.AddComponent<Rigidbody>();
                cube.transform.parent = this.transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

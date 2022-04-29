using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrStationManager : MonoBehaviour
{
    public GameObject[] frames;
    [Range(0.0f, 2.0f)]
    public float speed;
    public Material[] materials;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < frames.Length; i++)
        {
            frames[i].GetComponent<MeshRenderer>().material = materials[i%materials.Length];
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < frames.Length; i++)
        {
            frames[i].transform.localPosition += new Vector3(0f, Mathf.Sin(10f * i + Time.time) * Time.deltaTime * speed, 0f);
        }
    }
}

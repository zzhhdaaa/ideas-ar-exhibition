using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class FiltersManager : MonoBehaviour
{
    private Volume volume;
    public VolumeProfile[] profiles;
    private int id = 0;

    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
        volume.profile = profiles[id];
    }

    public void ChangeFilters()
    {
        if (id < profiles.Length-1)
        {
            id++;
            volume.profile = profiles[id];
        }
        else
        {
            id = 0;
            volume.profile = profiles[id];
        }
    }
}

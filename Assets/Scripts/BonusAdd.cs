using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusAdd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BonusManager.instance.count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

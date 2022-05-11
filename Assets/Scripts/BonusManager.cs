using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{
    public GameObject bonus;

    [HideInInspector]
    public static BonusManager instance;
    [HideInInspector]
    public int count;

    private bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= 4 && isFirst)
        {
            GameObject.Instantiate(bonus, transform.position, Quaternion.identity);
            isFirst = false;
        }
    }
}

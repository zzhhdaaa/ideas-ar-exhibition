using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessingManager : MonoBehaviour
{
    /*
    public GameObject ppReal;
    public GameObject ppBloom;
    public GameObject ppContrast;
    */

    public List<GameObject> pps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
     public void PPreal()
    {
        ppReal.SetActive(true);
        ppBloom.SetActive(false);
        ppContrast.SetActive(false);
    }
    public void PPbloom()
    {
        ppReal.SetActive(false);
        ppBloom.SetActive(true);
        ppContrast.SetActive(false);
    }
    public void PPContrast()
    {
        ppReal.SetActive(false);
        ppBloom.SetActive(false);
        ppContrast.SetActive(true);
    }*/

    public void PPSwitch(int id)
    {
        if(id >=0 && id < pps.Count)
        {
            for(int i = 0; i < pps.Count; i++)
            {
                if(i == id)
                {
                    pps[i].SetActive(true);
                }
                else
                {
                    pps[i].SetActive(false);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShow : MonoBehaviour
{
    public GameObject[] gameObjects;

    public void Switch()
    {
        foreach (GameObject go in gameObjects)
        {
            go.SetActive(!go.activeInHierarchy);
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject destoryObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string objectName;
    public Vector3 pos;
    public Quaternion rot;
    void Awake()
    {
        Debug.Log("Awake");
        CreateCharacter();
    }
    void Start()
    {  
        Debug.Log("Start");
        Destroy(destoryObj, 3f);
    }

    void CreateCharacter()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = objectName;

    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }


}

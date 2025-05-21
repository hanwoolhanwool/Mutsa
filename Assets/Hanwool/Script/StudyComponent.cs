using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string changeName;
    void Start()
    {
        obj = GameObject.Find("Cube");

        obj.name = changeName;
    }
}

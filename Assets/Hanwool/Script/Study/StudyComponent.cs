using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    /*
    private GameObject obj;
    public Transform objTf;
    public string changeName;
    */
    public Mesh msh;
    public Material mat;
    void Start()
    {  
        CreateCube();





        /*
        obj = GameObject.Find("Cube");

        obj.name = changeName;

        objTf = GameObject.FindGameObjectWithTag("Player").transform;

        obj.SetActive(false);
        */
    }

    private void CreateCube()
    {
        
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();


        obj.GetComponent<MeshFilter>().mesh = msh;
        obj.GetComponent<MeshRenderer>().material = mat;
    }
}

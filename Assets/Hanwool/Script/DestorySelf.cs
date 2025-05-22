using UnityEngine;

public class DestorySelf : MonoBehaviour
{
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, time);
    }

    void OnDestroy()
    {
        Debug.Log("Destroy" + this.gameObject.name);
    }
}

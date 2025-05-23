using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);


        Destroy(this.gameObject, 5f);
    }
}

using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab;
    public Transform firePos;
    void Start()
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {   
        turretHead.LookAt(targetTf);

        if (Input.GetKey(KeyCode.Space))
        {
            BulletSpwan();
        }
    }

    void BulletSpwan()
    {
        Debug.Log("총알 발사");
        Instantiate(bulletPrefab,firePos.position,firePos.rotation);
    }
}

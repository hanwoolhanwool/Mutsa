using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Update is called once per frame
    public float rotSpeed;

    private bool isStop = false;
    void Start()
    {
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 50f;

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if( isStop == true)
        {
            rotSpeed *= 0.98f;
            
            if(rotSpeed < 0.1f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }

        transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
    }
}

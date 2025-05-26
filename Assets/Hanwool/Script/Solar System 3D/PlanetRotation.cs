using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet; // 공정할 행성 = 태양
    public float rotSpeed = 10f; // 자전 속도
    public float revolutionSpeed = 100f; // 공전 속도

    public bool isRevolution = false; // 공전 여부부


    void Update()
    {
        RotationToSelf();

        if(isRevolution)
        {
            RevolutionToPlanet();
        }
        
    }

    void RotationToSelf()
    {
        this.transform.Rotate(Vector3.up* rotSpeed * Time.deltaTime); // 자전
    }


    void RevolutionToPlanet()
    {
            this.transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime); // 공전
    }
}

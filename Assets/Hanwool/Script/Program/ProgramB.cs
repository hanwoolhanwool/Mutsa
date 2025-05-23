using UnityEngine;
using Dev4;

public class ProgramB : MonoBehaviour
{  
    public ProgramA pA;

    void Start()
    {
        //pA.Number1 = 0;             // 접근 불가
        pA.Number2 = 0;       // 접근 가능
        //pA.Number3 = 0;      // 접근 불가
        //pA.Number4 = 0;    // 접근 불가

        //pA.Number5 = 0;        // 접근 블가
    }
}

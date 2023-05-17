using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Test : MonoBehaviour
{  
        
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌 시작");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 끝");
    }
}

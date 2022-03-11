using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){

        if(collision.gameObject.CompareTag("Obsticale")){
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    [SerializeField] float speed = 5.0f;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        scoretext.text="Score: 235";
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);



        if(Input.GetKey(KeyCode.W) ){
           transform.localScale = new Vector3(1, 7, 1);
        }
        if(Input.GetKey(KeyCode.A)){
        
        }
        if(Input.GetKey(KeyCode.S)){
            transform.localScale = new Vector3(4, 1, 1);
        }
        if(Input.GetKey(KeyCode.D)){
             transform.localScale = new Vector3(2, 2, 1);
        }
    }
}

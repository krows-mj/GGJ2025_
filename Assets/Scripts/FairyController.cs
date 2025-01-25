using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyController : MonoBehaviour
{
    private Rigidbody rb;
    [Header("Variables")]
    [SerializeField][Range(0f, 10f)] private float speed;
    public float hmov, vmov;
    private Vector3 vectorMove;
    [Header("Proyectil/Burbuja")]
    [SerializeField] private GameObject Bulled;
    
    private void Awake(){
        rb= GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bulletBubble
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Lanza burbuja");
        }
    }
    private void FixedUpdate(){
        hmov= Input.GetAxis("HorizontalF");
        vmov= Input.GetAxis("VerticalF");
        vectorMove= new Vector3(hmov, vmov, 0f);
        vectorMove= Vector3.ClampMagnitude(vectorMove, 1);
        rb.velocity= vectorMove * speed;
    }
}

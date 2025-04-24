using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float moveSpeed = 2;
    [SerializeField]
    
    
    private Rigidbody rb;
    [SerializeField]
    private float jumpForce = 1000f;
    private MeshRenderer rbMesh;
  
    [SerializeField]
    private Color mycolor;

    
    void Start()
    {
        Debug.Log("Start");
        rb = GetComponent<Rigidbody>();
        
        

    }       

    
    void Update()
    {
        
        

        
        transform.Translate(1 * moveSpeed * Time.deltaTime , 0, 0 );
        


        if (Input.GetKeyDown(KeyCode.Space)){

       
            rb.AddForce(0, jumpForce , 0);
            
        }

        









    }
    private void OnCollisionEnter(Collision collision)
    {
        //collision.gameObject.GetComponent<MeshRenderer>().material.color = mycolor;
        
        
        
         
    }
    private void OnCollisionExit(Collision collision)
    {
        
        
    }
}

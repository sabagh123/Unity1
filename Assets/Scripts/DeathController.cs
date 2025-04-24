using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    private MeshRenderer rbMesh;
    [SerializeField]
    private Color mycolor;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Pillar")
        {
            rbMesh = GetComponent<MeshRenderer>();
            rbMesh.material.color = mycolor;
            collision.gameObject.GetComponent<MeshRenderer>().material.color = mycolor;
            SceneManager.LoadScene(0);
        }

    }
    private void OnCollisionExit(Collision collision)
    {


    }
}

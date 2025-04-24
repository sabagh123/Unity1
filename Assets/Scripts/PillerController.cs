using UnityEngine;

public class PillerController : MonoBehaviour
{
    public GameObject GameObject;
    public int pillersCount;
    public float distanceBetweenPillers;

    private float y = -3.441633f;
    private float z = -6.071034f;
    private void Start()
    {
        for (int i = 0; i < pillersCount; i++)
        {
            Instantiate(GameObject.transform, new Vector3(i * distanceBetweenPillers,0, 0), Quaternion.identity);


        }
    }
}

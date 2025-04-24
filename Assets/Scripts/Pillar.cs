using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Pillar : MonoBehaviour
{
    public float TopMax = 2;
    public float TopMin = 5f;
    public float BottomMax = -5;
    public float BottomMin = -2;
    public Transform pillar1;
    public Transform pillar2;
    
    void Start()
    {
        float topY = Random.Range(TopMin, TopMax);
        float bottomY = Random.Range(BottomMin, BottomMax);
        pillar1.localPosition = new Vector3(0, topY, 0);
        pillar2.localPosition = new Vector3(0, bottomY, 0);
    }

    
    
}

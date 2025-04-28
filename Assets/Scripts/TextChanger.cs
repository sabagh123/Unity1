using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class TextChanger : MonoBehaviour
{
    public Button btn1;
    public TMP_Text label;
    public Button btn2;
    
    private void Start()
    {
        


        btn1.onClick.AddListener(() => 
        {
            label.text = "2";
            label.color = Color.red;
            
            }); 
        
        btn2.onClick.AddListener(() => {
            int count;
            if(int.TryParse(label.text,out count))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            label.text =count.ToString();
            label.color = Color.green;
            
            
            }
        );
    }
}

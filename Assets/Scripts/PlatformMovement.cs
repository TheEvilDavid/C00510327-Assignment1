using UnityEngine;
using UnityEngine.UIElements;

public class PlatformMovement : MonoBehaviour
{
    public GameObject platform;
    public GameObject target;
    public GameObject target2;
    bool origin;
    bool destination;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject temp = target;

      platform.transform.position = Vector3.MoveTowards(platform.transform.position, target.transform.position, 2 * Time.deltaTime);
        if(platform.transform.position == target.transform.position)
        {
            target = target2;
            target2 = temp;
        }
           
       
        
        
        
    }
}

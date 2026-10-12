using Unity.VisualScripting;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    
    public Collider cb;
    public MeshRenderer visable;
    
    
    GameObject thisStar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cb = GetComponent<Collider>();
        visable = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        StarCounter.instance.AddStar();
        Debug.Log("You got a star!");
        Destroy(cb);
        Destroy(visable);
        
    }
    
}

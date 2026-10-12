using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Finishing : MonoBehaviour
{
    public GameObject star;
    public static Finishing instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnStars() {
        Instantiate(star, transform.position, transform.rotation);
    }
}

using UnityEngine;

public class Tumbleweed : MonoBehaviour
{

    public Rigidbody rB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

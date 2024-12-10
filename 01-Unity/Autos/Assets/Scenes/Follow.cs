using UnityEngine;

public class Follow : MonoBehaviour
{

    [SerializeField] private GameObject cosaASeguir;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cosaASeguir.transform.position + new Vector3(0, 0, -10);
    }
}

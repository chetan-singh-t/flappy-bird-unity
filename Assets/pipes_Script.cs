using UnityEngine;

public class pipes_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Movie_speed = 5;
    public float dead_zone = -16;


    private void Start()
    {
       
    }
    // Update is called once per frame
    private void Update()
    {
        transform.position +=(Vector3.left * Movie_speed)* Time.deltaTime;
        if(transform.position.x < dead_zone)
        {
            Destroy(gameObject);
        }
    }



}

using UnityEngine;

public class Pipestest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Pipe;
    public float spawnrate = 2;
    private float time = 0;
    public float heigthoffset = 10;


    private void Start()
    {
        SpawnPipes();
    }
    // Update is called once per frame
    private void Update()
    {
        if (time < spawnrate)
        {
            time += Time.deltaTime;
        }
        else {
            SpawnPipes();
            time = 0;
        }
        
    }
    void SpawnPipes()
    {
        float lowestpoint = transform.position.y - heigthoffset;
        float highestpoint = transform.position.y + heigthoffset;

        Instantiate(Pipe, new Vector2(transform.position.x,Random.Range(highestpoint,lowestpoint)), transform.rotation);
    }

 

}

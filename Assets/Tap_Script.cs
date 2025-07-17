using UnityEngine;

public class Tap_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject tapText;
    bool gameStarted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            tapText.SetActive(false);
        }
    }
}

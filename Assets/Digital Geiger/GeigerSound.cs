using UnityEngine.Audio;
using UnityEngine;

public class GeigerSound : MonoBehaviour
{
    public AudioSource source;
    public GameObject artifact;
    private float timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float distance = Vector3.Distance (this.transform.position, artifact.transform.position);
        timer += Time.deltaTime;
        float geigerDistFunc;
        if (distance > 13.0f)
        {
            geigerDistFunc =  Mathf.Pow(distance, 2)*0.0004f;
        } else 
        {
            geigerDistFunc = Mathf.Pow(13.0f, 2)*0.0004f;;
        }
        //geigerDistFunc =  Mathf.Pow(distance, 2)*0.004f;
        if (timer > geigerDistFunc) 
        {
            source.Play();
            timer = 0;
        }
    }
}

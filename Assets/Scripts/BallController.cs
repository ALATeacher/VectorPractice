using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody body;
    public TMPro.TMP_InputField XInput;
    public TMPro.TMP_InputField YInput;
    public TMPro.TextMeshProUGUI timeOutput;
    public TMPro.TextMeshProUGUI rangeOutput;
    private float startTime = 0;
    private bool timer = false;
    public float xFactor;
    // Start is called before the first frame update
    void Start()
    {
        body = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<=0 && timer && Time.time-startTime>1)
        {
            string t = ""+(Time.time-startTime);
            Debug.Log(t);
            timeOutput.text = "Time: "+t;
            timer = false;
            Debug.Log(transform.position);
            rangeOutput.text = "Range: "+transform.position.x;
        }
    }

    public void launch()
    {
        string x = XInput.text;
        string y = YInput.text;
        Vector3 v = new Vector3(float.Parse(x)*xFactor,float.Parse(y), 0);
        Debug.Log(v);
        body.AddForce(v);
        startTime = Time.time;
        timer = true;
    }

    public void resetAll()
    {
        gameObject.transform.position = new Vector3(0,0,0);
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
    }
}

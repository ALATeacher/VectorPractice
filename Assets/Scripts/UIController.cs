using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string coords = "Target Coordinates: ("+target.transform.position.x+","+target.transform.position.y+")";
        GetComponent<TMPro.TextMeshProUGUI>().text = coords;
    }
}

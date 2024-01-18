using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private GameObject camera;
    private GameObject unitychan;
    // Start is called before the first frame update
    void Start()
    {
        this.camera = GameObject.Find("Main Camera");
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.camera.transform.position.z);


    }

    void OnTriggerEnter(Collider item){        
        
        if(item.gameObject.tag == "CarTag" || item.gameObject.tag == "CoinTag" || item.gameObject.tag == "TrafficConeTag"){
            Destroy(item.gameObject);
        }
        
    }
}

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideManager : MonoBehaviour {
    public GameObject ship;
    public float offset = 2;
    // Use this for initialization

    private static SideManager sideManager;
    void Start () {
        if (sideManager == null) { sideManager = this; }
	}
	
    public static SideManager getInstance() { return sideManager; }

    // Update is called once per frame
    void Update () {
		
	}

    public void Teletransport(BorderTrigger side,GameObject other) {
        if (side.getSide()== BorderTrigger.Side.L) {
            other.transform.position = new Vector3(-side.transform.position.x-offset , other.transform.position.y, other.transform.position.z);
        }
        if (side.getSide() == BorderTrigger.Side.B) {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, -side.transform.position.z- offset);
        }
        if (side.getSide() == BorderTrigger.Side.R) {
            other.transform.position = new Vector3(-side.transform.position.x+ offset, other.transform.position.y, other.transform.position.z);
        }
        if (side.getSide() == BorderTrigger.Side.T) {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, -side.transform.position.z+ offset);
        }


    }

}

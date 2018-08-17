using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderTrigger : MonoBehaviour {
    public enum Side {L,R,T,B };
    public Side side;

    private void OnTriggerEnter(Collider other) { 
        SideManager.getInstance().Teletransport(this,other.gameObject);
        Debug.Log("Choco");
    }

    public Side getSide() {
        return this.side;
    }
}

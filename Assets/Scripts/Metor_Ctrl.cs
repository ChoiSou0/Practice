using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metor_Ctrl : MonoBehaviour
{
    public int Speed;

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.position = new Vector3
            (this.transform.position.x, this.transform.position.y, this.transform.position.z - Speed);
    }
}

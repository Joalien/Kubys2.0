using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour {

    public ProgressBar Pb;
    public ProgressBarCircle PbC;

    private void Start()
    {
        Pb.Current = 50;
        Pb.Maximum = 100;
        PbC.BarValue = 50;
    }

    void FixedUpdate () {
		
        if(Input.GetKey(KeyCode.KeypadPlus))
        {
            Pb.Current += 1;
            PbC.BarValue += 1;
        }

        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            Pb.Current -= 1;
            PbC.BarValue -= 1;
        }
    }
}

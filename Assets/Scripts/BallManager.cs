using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;

    bool GyroCalibrated = false;

    Quaternion Base = new Quaternion();

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.orientation = ScreenOrientation.Portrait;
        Input.gyro.enabled = true;
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GyroCalibrated)
        {
           // Debug.Log(Input.gyro.attitude);
            rb.AddForce(new Vector3(Base.y + Input.gyro.attitude.y*3, Base.x - Input.gyro.attitude.x*6, 0), ForceMode.Acceleration);
        }

        }

        public void Calibrate()
    {
        Base = Input.gyro.attitude;
        GyroCalibrated = true;
    }
}

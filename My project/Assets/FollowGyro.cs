using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowGyro : MonoBehaviour
{
    [Header("Tweaks")]
    private Quaternion baseRotation = new Quaternion(0,0, 1, 0);

    public Text text;
    private void Start() {
        GyroManager.Instance.EnableGyro();
        transform.rotation = Quaternion.Euler(-90f,90f,0f);
    }

    private void Update()
    {
        transform.localRotation = GyroManager.Instance.GetGyroRotation() * baseRotation;
        //transform.rotation.x += 90f;
        text.text = transform.localRotation.ToString();
    }
}

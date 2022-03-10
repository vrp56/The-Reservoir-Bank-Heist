using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwap : MonoBehaviour
{
    public GameObject TargetCamPost;
    public GameObject TargetCam;
    public Transform CameraRig;
    public GameObject LeftController;
    public GameObject RightController;
    public GameObject OVRPlayerController;
    private OVRPlayerController QuestPlayerControllerScript;
    
    private Transform PlayerCamTransform;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamTransform = CameraRig.GetComponentInParent<Transform>();
        QuestPlayerControllerScript = OVRPlayerController.GetComponent<OVRPlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            QuestPlayerControllerScript.EnableLinearMovement = true;
            CameraRig.localPosition = new Vector3(0f, 0f, 0f);
            CameraRig.rotation = new Quaternion(0f, 0f, 0f, 0f);
            TargetCamPost.GetComponentInChildren<MeshRenderer>().enabled = true;
            TargetCam.GetComponentInChildren<MeshRenderer>().enabled = true;
            LeftController.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;
            RightController.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;

            TargetCamPost.GetComponentInChildren<Animation>().Play();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        QuestPlayerControllerScript.EnableLinearMovement = false;
        CameraRig.position = TargetCamPost.transform.position;
        CameraRig.rotation = TargetCamPost.transform.rotation;
        TargetCamPost.GetComponentInChildren<MeshRenderer>().enabled = false;
        TargetCam.GetComponentInChildren<MeshRenderer>().enabled = false;
        LeftController.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;
        RightController.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;

        TargetCamPost.GetComponentInChildren<Animation>().Stop();
    }
}

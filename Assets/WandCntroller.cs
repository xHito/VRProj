using UnityEngine;
using System.Collections;

public class WandCntroller : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private bool gripBtnDown = false;
    private bool gripBtnUp = false;
    private bool gripBtnPressed = false;


    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private bool triggerBtnDown = false;
    private bool triggerBtnUp = false;
    private bool triggerBtnPressed = false;


    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (controller == null)
        {
            Debug.Log("Controller is not initialized");
            return;
        }

        gripBtnDown = controller.GetPressDown(gripButton);
        gripBtnUp= controller.GetPressUp(gripButton);
        gripBtnPressed = controller.GetPress(gripButton);

        triggerBtnDown = controller.GetPressDown(triggerButton);
        triggerBtnUp = controller.GetPressUp(triggerButton);
        triggerBtnPressed = controller.GetPress(triggerButton);

        if (gripBtnDown)
        {
            Debug.Log("Grip Button Pressed Down");
        }
        if (gripBtnUp)
        {
            Debug.Log("Grip Button Unpressed");
        }
        if (triggerBtnDown)
        {
            Debug.Log("trigger Button Pressed Down");
        }
        if (triggerBtnUp)
        {
            Debug.Log("trigger Button UnPressed");
        }
       
    }
}

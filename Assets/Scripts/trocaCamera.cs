using UnityEngine; 

public class trocaCamera : MonoBehaviour{ 

    public Camera CameraP; 
    public Camera CameraNave; 
    public Camera CameraM; 
    void Start() {
        CameraP.enabled = true;
        CameraNave.enabled = false;
        CameraM.enabled = false;
    } 
    
    void Update() {
            if (Input.GetKeyDown(KeyCode.C)){ 
            if (CameraP.enabled == true) {
                CameraNave.enabled = true; 
                CameraP.enabled = false; 
                CameraM.enabled = false; 
            } else if (CameraNave.enabled == true) {
                CameraNave.enabled = false;
                    CameraP.enabled = false;
                    CameraM.enabled = true;
            } else if (CameraM.enabled == true) {
                    CameraNave.enabled = false;
                    CameraP.enabled = true;
                    CameraM.enabled = false;
            } 
        } 
    }
}
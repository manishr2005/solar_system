using UnityEngine;

public class ChangeLookAt : MonoBehaviour
{
    // Declare a game object variable which defines the target where the camera should look at 
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject;
            Debug.Log("change look target is not specified. defaulting to parent object.");
        }  
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
        
    }
}

using UnityEngine;

public class Camera3DLERP : MonoBehaviour {
    public Transform target;     // drag intended Player object into Inspector slot
    public float smoother = 5f;
    public Vector3 offset;     // set the offset in the editor

    void FixedUpdate () {
       Vector3 newPos = target.position + offset;
       Vector3 smPos = Vector3.Lerp (transform.position, newPos, smoother * Time.deltaTime);
       transform.position = smPos;

       transform.LookAt (target);
    }
}
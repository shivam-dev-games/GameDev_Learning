using UnityEngine;

public class SpinObject : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 90f;

    void Update()
    {
        transform.Rotate(
            Vector3.up * rotationSpeed * Time.deltaTime
        );
    }
}
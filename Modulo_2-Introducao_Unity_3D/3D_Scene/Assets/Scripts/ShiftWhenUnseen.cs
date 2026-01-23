using UnityEngine;

public class ShiftWhenUnseen : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 0.2f, 0);
    public float delay = 1f;
    public float viewAngle = 45f;

    private Transform cam;
    private Vector3 startPos;
    private float timer;

    void Start()
    {
        cam = Camera.main.transform;
        startPos = transform.position;
        Debug.Log("Script OK em " + gameObject.name);
    }

    void Update()
    {
        Vector3 dir = (transform.position - cam.position).normalized;
        float angle = Vector3.Angle(cam.forward, dir);

        if (angle > viewAngle)
        {
            timer += Time.deltaTime;

            if (timer >= delay)
                transform.position = startPos + offset;
        }
        else
        {
            timer = 0;
            transform.position = Vector3.Lerp(
                transform.position,
                startPos,
                Time.deltaTime * 0.5f
            );
        }

    }
}

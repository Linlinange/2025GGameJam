using UnityEngine;

public class BubbleNormal : MonoBehaviour
{
    public float �����ٶ� = 1f;

    private void Awake()
    {
        enabled = false;
    }
    private void Update()
    {
        // ÿ������
        transform.position += new Vector3(0, �����ٶ� * Time.deltaTime, 0);
    }
}

using UnityEngine;

public class GizmoEnemySpammer : MonoBehaviour 
{
    public float Radius = 5.0f;

    [Header("Color")]
	public float r;
    public float g;
    public float b;
    public float alpha;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(r, g, b, alpha);

        Gizmos.DrawSphere(gameObject.transform.position, Radius);
    }
}

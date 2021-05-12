using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    
    public Transform My_Player;
    [SerializeField]
    private float speed = 10f;
    void OnMouseDrag()
    {
        if (!Player.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.2f ? 2.2f : mousePos.x;
            mousePos.x = mousePos.x < -2.2f ? -2.2f : mousePos.x;
            My_Player.position = Vector2.MoveTowards(My_Player.position,
                new Vector2(mousePos.x, My_Player.position.y),
                speed * Time.deltaTime);
        }
    }
}
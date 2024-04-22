using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    [SerializeField] private CharacterController _charController;
    [SerializeField] private float _speed;
    public bool _look;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var move = new Vector3(horizontal, 0, vertical);
        _charController.SimpleMove(move * _speed);
        //if (!_look)
        //{
        //    if (horizontal == 0 && vertical == 0)
        //        transform.forward = move;
        //    else
        //        transform.up = move;


        //}
    }
}

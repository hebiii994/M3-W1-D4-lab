using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    [SerializeField] private float _velocita = 5;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Vector2 maxDistance = new Vector2(11, 6);
    [SerializeField] private Vector2 startPosition = new Vector2(0, 0);





    // Start is called before the first frame update
    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        _rb.position = startPosition;
        

      

    }

    private void Update()
    {
        Debug.Log(_rb.position);

        if (_rb.position.x >= maxDistance.x || _rb.position.y >= maxDistance.y)
        {
            _rb.position = startPosition;

        }
        else if (_rb.position.x <= -maxDistance.x || _rb.position.y <= -maxDistance.y)
        {
            _rb.position = startPosition;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _rb.MovePosition(_rb.position + direction * (_velocita * Time.deltaTime));
        


    }






}

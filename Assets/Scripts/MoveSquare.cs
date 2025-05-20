using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{

    [SerializeField] private float _velocita = 5;
    [SerializeField] private Rigidbody2D _rb;
    // [SerializeField] private Vector2 maxDistance = new Vector2(11, 6);
    [SerializeField] private float maxRadius = 10f; // Esempio: raggio di 10 unità
    [SerializeField] private Vector2 startPosition;





    // Start is called before the first frame update
    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        startPosition = _rb.position;

    }

    private void Update()
    {
        Debug.Log(_rb.position);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;

        _rb.MovePosition(_rb.position + direction * (_velocita * Time.deltaTime));

        float currentDistance = Vector2.Distance(_rb.position, startPosition);
        if (currentDistance > maxRadius)
        {
            _rb.position = startPosition;
        }


        }






}

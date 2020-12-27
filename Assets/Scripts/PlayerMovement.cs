using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    [SerializeField] private float _movementForce = 7f;
    [SerializeField] private double _maximumVelocity = 4f;
    [SerializeField] private float _turnSpeed = 30f;
    [SerializeField] private float runSpeed = 6f;
    [SerializeField] private bool _shouldRun=false;
    [SerializeField] private float shrink = 0.5f;


    private void Awake() {
     _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
         
            
    }
    private void FixedUpdate()
    {
        _shouldRun = Input.GetKey(KeyCode.LeftShift);
        if(transform.localScale.y<1f && !Input.GetKey(KeyCode.C) )
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y+shrink, transform.localScale.z);

        if (Input.GetKey(KeyCode.Q) )
            _rigidbody.transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.down);
        
        if (Input.GetKey(KeyCode.E))
            _rigidbody.transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.up);
        
        if( _shouldRun){
            if (Input.GetKey(KeyCode.W)  ){
                _rigidbody.AddForce(_movementForce * transform.forward * runSpeed);
            }
            if (Input.GetKey(KeyCode.A) ){
              _rigidbody.AddForce(_movementForce * -transform.right * runSpeed);

            }   
            if (Input.GetKey(KeyCode.D)   ){
             _rigidbody.AddForce(_movementForce * transform.right * runSpeed);
            }
            if (Input.GetKey(KeyCode.S)   ){
             _rigidbody.AddForce(_movementForce * -transform.forward * runSpeed);
            }

        }
        else if (_rigidbody.velocity.magnitude >= _maximumVelocity){
            return;
        }

        else
        {

            if(Input.GetKey(KeyCode.C) && transform.localScale.y>0.5f ){
                transform.position = new Vector3(transform.position.x, transform.position.y - shrink, transform.position.z);
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y-shrink, transform.localScale.z);
                move();
            }
            else{
                move();
            }
         }

    }
        public void move(){
            if (Input.GetKey(KeyCode.W) )
              _rigidbody.AddForce(_movementForce * transform.forward);
            
        
           if (Input.GetKey(KeyCode.S))
              _rigidbody.AddForce(_movementForce * -transform.forward); // -forward gives us back



         if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_movementForce * transform.right);
        



         if (Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(_movementForce * -transform.right); // -right gives us left
              
        }
}
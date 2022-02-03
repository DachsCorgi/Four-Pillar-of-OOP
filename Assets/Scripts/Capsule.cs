
using UnityEngine;


// INHERITANCE
public class Capsule : ClickableUnit
{
    private Rigidbody unitRb;

    
    private bool isClicked = false;

    [SerializeField]
    private float force = 0;


    // POLYMORPHISM
    protected override void handleClick()
    {
        isClicked = true;
    }

    private void Start()
    {
        unitRb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 forwardVector = Camera.main.transform.forward;
        if(isClicked)
        {
            unitRb.AddForce(forwardVector * force, ForceMode.Impulse);
            isClicked = false;
        }
    }

}

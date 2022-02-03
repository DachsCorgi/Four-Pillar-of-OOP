
using UnityEngine;

public abstract class ClickableUnit : MonoBehaviour
{


    protected abstract void handleClick();

    protected virtual void OnUpdate()
    {

    }


    // ABSTRACTION
    private void handleClickEvent()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();

            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                handleClick();
            }
        }
    }

    // Encapsulation
    private void Update()
    {
        handleClickEvent();
        OnUpdate();

    }
}

using UnityEngine;

public class Cards : MonoBehaviour
{
    //Para arrastrar la carta
    private void OnMouseDrag()
    {
        transform.position = Input.mousePosition;
    }

    //Para seleccionar la carta
    private void OnMouseDown()
    {
        print ("Carta seleccionada");
        GetComponent<BoxCollider2D>(); //algo debería hacer
    }

    //Para soltar la carta
    private void OnMouseUp()
    {
        
    }
}

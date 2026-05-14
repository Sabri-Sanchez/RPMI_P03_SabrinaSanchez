using UnityEngine;

public class Cards : MonoBehaviour
{
    public GameObject CombatSystem;

    //Para arrastrar la carta
    private void OnMouseDrag()
    {
       Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0;
        transform.position = pos;
    }

    //Para seleccionar la carta
    private void OnMouseDown()
    {
        print ("Carta seleccionada");
        GetComponent<SpriteRenderer>().sortingOrder = 100;
        GetComponent<SpriteRenderer>().sortingLayerName = "SelectedCard"; //Esto poner falso box collider
    }

    //Para soltar la carta
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 0;
        GetComponent<SpriteRenderer>().sortingLayerName = "Default"; //Ponerlo en verdadero
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy")) 
        {
            print("Choque enemigo"); 
            CombatSystem CS = Instantiate(CombatSystem,collision.collider.transform.position, Quaternion.identity).GetComponent<CombatSystem>();
            CS.PlayerCard = gameObject;
            CS.EnemyCard = collision.collider.gameObject;
        }

        //Sistema de combate start sea capaz de eliminar, comprobar cual tiene mas vida y que destruya la que tiene menos vida. Ponerlo en la pantalla también los datos y que se actualicen.
        
    }
}

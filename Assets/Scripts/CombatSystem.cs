using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public GameObject PlayerCard;
    public GameObject EnemyCard;

    public Transform PlayerPosition;

    void Start()
    {
        print("mensaje");
        PlayerCard.transform.position = PlayerPosition.transform.position;
        //PlayerCard.GetComponent<Cards>();
        Destroy(PlayerCard.GetComponent<Cards>());
    }

   
}

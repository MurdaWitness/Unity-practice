using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float weight = 0f;
    public float money = 0f;
    public float price = 30;
    public float rate = 1f;
    public float pickaxeForce = 1f;

    void Update()
    {
        Move();
    }

    public void Mine(Ore ore)
    {
        if (ore.amount >= 0)
        {
            if (ore.amount - pickaxeForce >= 0)
            {
                weight += pickaxeForce;
                ore.amount -= pickaxeForce;
            }
            else
            {
                weight += ore.amount;
                Destroy(ore.gameObject);
            }
            EventsHandler.instance.inventoryChanged.Invoke();
        }
    }

    private void SellOre()
    {
        money += weight * price;
        weight = 0f;
    }

    private void OnTriggerStay(Collider collision)
    {
        if(Input.GetKeyDown(KeyCode.E) && collision.gameObject.CompareTag("Shop"))
        {
            SellOre();
            EventsHandler.instance.inventoryChanged.Invoke();
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3.back * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}

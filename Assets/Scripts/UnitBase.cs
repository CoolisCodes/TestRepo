using UnityEngine;

public abstract class UnitBase : MonoBehaviour
{
    public string name;
    public int health;

    public abstract void Attack();

    public void Select()
    {
        Debug.Log("I Am selected");
    }
}

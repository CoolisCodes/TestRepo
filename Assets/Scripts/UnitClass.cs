using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitClass : MonoBehaviour, IInteractable
{
    public void Interract()
    {
        Debug.Log("interracted!");
    }
}


public interface IInteractable
{
    void Interract();
}
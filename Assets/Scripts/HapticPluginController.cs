using System;
using UnityEngine;
using UnityEngine.Serialization;

public class HapticPluginController : MonoBehaviour
{

    [SerializeField] private HapticPlugin hp;

    [SerializeField] private Vector3 currentAppliedForce; 
    private void Awake()
    {
        hp = GetComponent<HapticPlugin>(); 
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentAppliedForce = hp.CurrentForce; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    
    private void Start()
    {
        UIModule.Instance.Initialize();
        UIModule.Instance.PopUpWindow<CreateRoleName>();
    }

    
    private void Update()
    {
        
    }
}

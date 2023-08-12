using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotator : MonoBehaviour
{
   [SerializeField] private float force;

   private void FixedUpdate()
   {
      transform.Rotate(new Vector3(0,0,force));
      
   }
}

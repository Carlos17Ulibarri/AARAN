using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controldelastronauta : MonoBehaviour
{
    [Header("Variables Movimiento Del Personaje")]
   public Joystick joystickMove;
   public Transform player;
   public Transform cam;
   public CharacterController controller;
   public float speed = 10f;
   private float rotacionSuave = 0.1f;
   float velocidadRotacionSuave;
   float horizontal;
   float vertical;

   [Header("Variable de suelo")]
   public float gravedad = 9.81f;

   [Header("Variables de Animación")]
   public Animator animator;
   public string variableMovimiento;


   Vector3 move;

   

   void Move()
   {
        float horizontal = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        float vertical = joystickMove.Vertical + Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(horizontal,0f,vertical).normalized;
        animator.SetFloat(variableMovimiento, (Mathf.Abs(vertical) + Mathf.Abs(horizontal)));

        if(direccion.magnitude >= 0.1f){
            float anguloARotar = Mathf.Atan2(direccion.x, direccion.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloARotar, ref velocidadRotacionSuave, rotacionSuave);
            transform.rotation = Quaternion.Euler(0f,angulo,0f);

            Vector3 direccionDelMovimiento = Quaternion.Euler(0f, anguloARotar, 0f) * Vector3.forward;
            controller.Move(direccionDelMovimiento.normalized * speed * Time.deltaTime);
        }

        move.y += -gravedad * Time.deltaTime;
        
        controller.Move(move * Time.deltaTime);
   }  

   

   private void Update()
   {
       Move();
   }
}
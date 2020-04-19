using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Verfoto_platillos : MonoBehaviour
{
    //Estos son los botones para ver las fotografías
    //Existen 2 ya que uno activara la animación de la foto cuando sale por primera vez
    //El segundo activará la animación de la fotografía cerrandose
    public Button Ver_foto1_Button;
    public Button Ver_foto2_Button;
    //Deseo desactivar los botones simultaneamente por lo tanto los declarare como Game Objects
    public GameObject Ver_foto1_GameObject;
    public GameObject Ver_foto2_GameObject;

    //Esta línea de código activara el sonido de flash
    public GameObject Flash;

    //Voy a mandar llamar a mi Animator controler de la fotografia del platillo
    public Animator anim_foto;

    //public Animator anim_foto;

    void Start()
    {
        Ver_foto1_Button.onClick.AddListener(Open);
        Ver_foto2_Button.onClick.AddListener(Close);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        //AQUI AL PRINCIPIO EL BOTON 1 ESTA EN TRUE POR ESO TIENE QUE SER DESACTIVADO
        Ver_foto1_GameObject.SetActive(false);
        Ver_foto2_GameObject.SetActive(true);
        anim_foto.SetBool("Spa", true);
        Debug.Log("presiona");
        Flash.SetActive(true);
    }
    public void Close()
    {
        //EN ESTA PARTE EL BOTON 1 VUELVE A SER TRUE Y EL OTRO ES DESACTIVADO
        Ver_foto1_GameObject.SetActive(true);
        Ver_foto2_GameObject.SetActive(false);
        anim_foto.SetBool("Spa", false);
        Debug.Log("apareci");
        Flash.SetActive(false);
    }

   
}

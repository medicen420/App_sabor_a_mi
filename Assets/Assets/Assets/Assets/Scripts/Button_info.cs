using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_info : MonoBehaviour
{
    //Estos son los botones como tal
    public Button btn1;
    public Button btn2;

    //estos son los botones pero declarados como Gameobjects
    
    public GameObject btn_obj1;
    public GameObject btn_obj2;


    public GameObject boton_verfotito;
    public GameObject boton_adiosfoto;

    //Esta es la información del platillo que aparecerá una vez que

    //se presione el botón de infromación
    public GameObject Info_spaguetti;
    public Animator anim_info_spaghetti;
    //Estos GameObjects sirven para indicar que en caso de que la fotografia de el platillo
    //se este mostrando y presionemos el boton de infor este desaparecera, sin necesidad de oprimir
    //por segunda vez el boton que nos permite visualizar las fotos

    //Esta es la fotografia del platillo
    public GameObject btn_verfotografiaplatillo;



    //public GameObject btn_adiosfoticos;

    public Animator boton_verfoto;
    



    // Start is called before the first frame update
    void Start()
    {
        btn1 = GetComponent<Button>();
        btn2 = GetComponent<Button>();

        

        //boton_verfotito.SetActive(false);
        //boton_adiosfoto.SetActive(false);

        btn1.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(TaskOnClick2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {

        //estos son los game objects de las fotos de los platillos
        //boton_verfotito.SetActive(true);
        //boton_adiosfoto.SetActive(false);
        btn_obj1.SetActive(false);
        btn_obj2.SetActive(true);

        anim_info_spaghetti.SetBool("chef_sopa", true);

        btn_verfotografiaplatillo.SetActive(true);
        


        //fotografia de el platillo se va a mostrar en pantalla cada vez que le demos click al boton de info
        //boton_verfoto.SetBool("ver", true);

        //image_spa.SetActive(true);

    }

    public void TaskOnClick2()
    {

        btn_obj1.SetActive(true);
        btn_obj2.SetActive(false);
        anim_info_spaghetti.SetBool("chef_sopa", false);
        //boton_verfotito.SetActive(false);
        //boton_adiosfoto.SetActive(false);

        //fotografia dejara de verse en pantalla cuando presionemos de nuevo el boton de info
        btn_verfotografiaplatillo.SetActive(false);



        //boton_verfoto.SetBool("ver", false);


    }


    

}

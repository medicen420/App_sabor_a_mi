using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_info : MonoBehaviour
{
    public Button btn;
    public Button btn2;
    public GameObject btn_info_1;
    public GameObject btn_info_2;
    public GameObject boton_verfotito;
    public GameObject boton_adiosfoto;
    //Estos GameObjects sirven para indicar que en caso de que la fotografia de el platillo
    //se este mostrando y presionemos el boton de infor este desaparecera, sin necesidad de oprimir
    //por segunda vez el boton que nos permite visualizar las fotos

    //Esta es la fotografia del platillo
    public GameObject btn_verfotografiaplatillo;


    //public GameObject btn_adiosfoticos;


    public Animator anim;
    public Animator anim_plato;
    public Animator chef;
    public Animator boton_verfoto;
    



    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        //boton_verfotito.SetActive(false);
        //boton_adiosfoto.SetActive(false);

       
        
        

        btn.onClick.AddListener(TaskOnClick);
        btn2.onClick.AddListener(TaskOnClick2);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        anim.SetBool("info", true);
        anim_plato.SetBool("sopa", true);
        
        btn_info_1.SetActive(false);
        btn_info_2.SetActive(true);
        chef.SetBool("chefcito", true);
        //estos son los game objects de las fotos de los platillos
        boton_verfotito.SetActive(true);
        boton_adiosfoto.SetActive(false);

        btn_verfotografiaplatillo.SetActive(true);


        //fotografia de el platillo se va a mostrar en pantalla cada vez que le demos click al boton de info




        //boton_verfoto.SetBool("ver", true);





        //image_spa.SetActive(true);

    }

    public void TaskOnClick2()
    {
        anim.SetBool("info", false);
        anim_plato.SetBool("sopa", false);
        btn_info_2.SetActive(false);
        btn_info_1.SetActive(true);
        chef.SetBool("chefcito", false);
        boton_verfotito.SetActive(false);
        boton_adiosfoto.SetActive(false);
        //fotografia dejara de verse en pantalla cuando presionemos de nuevo el boton de info
        btn_verfotografiaplatillo.SetActive(false);



        //boton_verfoto.SetBool("ver", false);


    }


    

}

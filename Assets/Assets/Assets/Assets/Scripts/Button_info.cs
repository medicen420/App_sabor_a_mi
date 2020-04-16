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
        boton_verfotito.SetActive(false);
        boton_adiosfoto.SetActive(true);
       
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


        //boton_verfoto.SetBool("ver", false);


    }


    

}

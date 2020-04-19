using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_informacion : MonoBehaviour
{
    //Este es el boton de información que el usuario podra presionar
    //para ver información acerca del platillo
    public Button boton_información1;
    //Este es el segundo boton de informacion, no es que hayan dos en la escena, si no que el primero se desactiva 
    public Button boton_información2;

    //Estos botones sirven para ver la fotografia real de el platillo
    public Button boton_verfoto1;
    //misma dinamica que la de el boton de informacion, este segundo boton sera desactivado
    public Button boton_verfoto2;

    public Animator animator_chef_sopa;
    

    //Ahora declararemos los mismos botones de arriba pero ahora como Gameobjects
    //para que de este modo se puedan mandar a activar o desactivar con SetActive


        //estos primeros son los botones de información
    public GameObject boton_gameobject1;
    public GameObject boton_gameobject2;

    //estos segundos son los botones que activaran la fotografia del platillo

    public GameObject boton_foto;
    public GameObject boton_foto_2;

    //Vamos a declarar la fotografia que aparecera del platillo como un GameObject
    public GameObject foto_plato;

    public Button_Verfoto_platillos script_foto;


    // Start is called before the first frame update
    void Start()
    {
        //Aqui estoy indicando que al presionar el boton la accion radica en el comportamiento
        //PressButton1
        boton_información1.onClick.AddListener(PressButton_Info);
        //PressButton2 este estara desactivado al principio
        boton_información2.onClick.AddListener(PressButton_Info2);

        //Los siguientes son los botones que activan la fotografia del platillo

        animator_chef_sopa.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PressButton_Info()
    {
        animator_chef_sopa.SetBool("chef_sopa", true);
        //Botones de Información
        boton_gameobject1.SetActive(false);
        boton_gameobject2.SetActive(true);
        //Camara_ilustracion.SetBool("ver foto", true);
        boton_foto.SetActive(true);




        //botones de la fotografia

        //Botones que activan la fotografia del platillo

    }


    //Recordemos que este boton esta desactivado pero al momento en el que yo presiono el primer boton este segundo se activa
    //ahora si podremos interactuar con el segundo boton y este al ser presionado, se activa una animacion en la que la ventana que aparecio
    //en el primer touch del boton, se cerrara.
    public void PressButton_Info2()
    {

        animator_chef_sopa.SetBool("chef_sopa", false);
        //Estos son los botones de informacion del platillo que se descativaran y activaran simultaneamente
        //con el objetivo de que se pueda volver a activar la animaci
        boton_gameobject1.SetActive(true);
        boton_gameobject2.SetActive(false);
        //Camara_ilustracion.SetBool("ver foto", false);
        boton_foto.SetActive(false);

        //Hemos llamado al script que esta dentro de los botones de ver fotografia 
        //para indicarle que si en caso de que el usuario llegue a presionar el segundo boton de informacion en lugar
        //de dar touch al boton de ver fotografia, la condicion bool dentro del animator de la fotografia es falsa por lo tanto
        //la foto se cerrara.
        script_foto.anim_foto.SetBool("Spa", false);
        script_foto.Ver_foto2_GameObject.SetActive(false);










    }

    //Posteriormente se vuelve a actrivar el primer boton y este segundo es nuevamente desactivado, esto lo hice con el objetivo de generar un bucle dentro
    //de el mismo script





}

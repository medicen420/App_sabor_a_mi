using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Verfoto_platillos : MonoBehaviour
{

    //estos son botones 
    public Button btn_verfoto;
    public Button btn_adiosfoto;
    //estos son los botones pero se utilizan como gameobjects
    public GameObject btn_verfoticos;
    public GameObject btn_adiosfoticos;
    //Este game object sera el efecto de sonido de una camara tomando una foto
    //haciendo referencia a la fotografía que va a aparecer
    public GameObject efecto_camara;

    
    //Esto es el animator que controla la animación de la fotografia del producto
    public Animator anim_foto;
    public Animator anim_button;
    // Start is called before the first frame update
    public Button_info script_buttoninfo;


    void Start()
    {
        btn_verfoto.onClick.AddListener(PressButtonver);
        btn_adiosfoto.onClick.AddListener(Adiosbuttonver);
        script_buttoninfo = GetComponent<Button_info>();
        //efecto_camara.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButtonver()
    {
        anim_foto.SetBool("Spa", true);
        anim_button.SetBool("ver", true);
        efecto_camara.SetActive(true);

        //El problema era que estaba activando el boton que se esta presionando y eso no tenia logica,
        //ya que no puedes activar algo que ya esta activado, asi que cuando presionas el boton este se desactiva y se activa otro nuevo
        //este nuevo sera el encargado de hacer lo que sigue dentro de la aplicación
        btn_verfoticos.SetActive(false);
        btn_adiosfoticos.SetActive(true);
        //Compartir el script fue la unica solucion para que se vuelva a activar la fotografia pero unicamente cuando presionamos el boton
        //de ver platillo o de visualizar la fotogreafía
        script_buttoninfo.btn_verfotografiaplatillo.SetActive(true);
       

        
        Debug.Log("andamos al 100");
    }

    public void Adiosbuttonver()
    {
        anim_foto.SetBool("Spa", false);
        anim_button.SetBool("ver", false);
        efecto_camara.SetActive(false);

        //Aqui cuando presionamos por segunda vez el boton, este se desactiva y el primero se activa para que
        //se respete el ciclo que hay en la programación, podriamos decir que va de arriba hacia abajo y de abajo hacia arriba
        btn_verfoticos.SetActive(true);
        btn_adiosfoticos.SetActive(false);
        


    }
}

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
    //Esto es el animator que controla la animación de la fotografia del producto
    public Animator anim_foto;
    public Animator anim_button;
    // Start is called before the first frame update
    void Start()
    {
        btn_verfoto.onClick.AddListener(PressButtonver);
        btn_adiosfoto.onClick.AddListener(Adiosbuttonver);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressButtonver()
    {
        anim_foto.SetBool("Spa", true);
        anim_button.SetBool("ver", true);
        btn_verfoticos.SetActive(false);
        btn_adiosfoticos.SetActive(true);
        Debug.Log("andamos al 100");
    }

    public void Adiosbuttonver()
    {
        anim_foto.SetBool("Spa", false);
        anim_button.SetBool("ver", false);
        btn_verfoticos.SetActive(true);
        btn_adiosfoticos.SetActive(false);
    }
}

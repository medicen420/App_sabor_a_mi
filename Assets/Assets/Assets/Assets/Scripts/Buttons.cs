using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Button buton;
    public Animator anima;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = buton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        anima.GetComponent<Animator>();
        anim.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        Debug.Log("me estas presionando");
        anima.SetBool("yes", true);
        anim.SetBool("yess", true);

    }


}

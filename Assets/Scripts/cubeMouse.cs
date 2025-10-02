using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class cubeMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    private Rigidbody m_rigidBody;
    private Renderer m_renderer;
    private Color m_color;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
        m_renderer = GetComponent<Renderer>();
        m_color = m_renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Pointeur sur cube");
        m_renderer.material.color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Pointeur sorti");
        m_renderer.material.color = m_color;

    }

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("Clic sur cube");
        m_rigidBody.AddForce(Camera.main.transform.forward * 500);
    }
}

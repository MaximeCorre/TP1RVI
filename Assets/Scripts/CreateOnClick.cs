using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    public GameObject aCopier;
    private GameObject playerCapsule;
    private Transform playerCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerCapsule = this.gameObject;
        playerCamera = playerCapsule.transform.GetChild(0);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnFire()
    {
        GameObject projectile = Instantiate(aCopier);

        projectile.transform.position = playerCapsule.transform.position + playerCapsule.transform.forward * 2.0f;
        projectile.transform.rotation = playerCamera.rotation;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(playerCamera.transform.forward * 2000.0f);
    }
}

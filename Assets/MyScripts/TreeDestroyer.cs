using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestroyer : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip breakSound;
    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Axe"))
        {
            aS.PlayOneShot(breakSound);
            StartCoroutine(DestroyDelay());
        }
    }

    public IEnumerator DestroyDelay()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FireRatePowerUp : MonoBehaviour
{

    private TextMeshPro _text;
   
    public float _fireRatePlus;

    private void Awake()
    {
        _text = GetComponent<TextMeshPro>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _fireRatePlus = Random.Range(1, 3);
        _text.text = "Fire Rate " +_fireRatePlus;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BulletMovement _))
        {
            _fireRatePlus++;
            Destroy(other.gameObject);
            _text.text = "Fire Rate   " + (_fireRatePlus);
        }

        if(other.gameObject.TryGetComponent(out BulletSpawn spawn))
        {
            spawn._spawnTime -= (_fireRatePlus / 500f);
            Destroy(this.gameObject);
        }
    }
}

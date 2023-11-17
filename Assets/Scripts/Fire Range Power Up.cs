using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FireRangePowerUp : MonoBehaviour
{

    
    private TextMeshPro _text;

    public float _fireRangePlus;

    private void Awake()
    {
        _text = GetComponent<TextMeshPro>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _fireRangePlus = Random.Range(1, 3);
        _text.text = "Fire Range " + _fireRangePlus;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BulletMovement _))
        {
            _fireRangePlus++;
            Destroy(other.gameObject);
            _text.text = "Fire Range   " + (_fireRangePlus);
        }

        if(other.gameObject.TryGetComponent(out BulletSpawn bulletspawn))
        {
            Destroy(this.gameObject);
            bulletspawn._bulletRange += _fireRangePlus/100;

        }
    }
}

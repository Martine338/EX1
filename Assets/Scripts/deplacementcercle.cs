using UnityEngine;

public class deplacementcercle : MonoBehaviour
{
    public float vitesseDeplacement = 0.01f;
    public bool peutBouger = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (peutBouger == true)
        {
            transform.Translate(0, vitesseDeplacement, 0);
        }

        if (transform.position.y > 6f)
        {
            transform.position = new Vector2(transform.position.x, 6f);
        }
        if (transform.position.y < -6f)
        {
            transform.position = new Vector2(transform.position.x, 6f);
        }
    }
}

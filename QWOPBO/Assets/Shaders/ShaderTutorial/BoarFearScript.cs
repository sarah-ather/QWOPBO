using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarFearScript : MonoBehaviour {



    public float scareFactorX = 0.01f;
    public float scareFactorY = 0.01f;

    private float waveEffectSize;
    private GameObject WaveEffect;
    private GameObject WaveEffect1;

    //private Vector2 offset = new Vector2(0f, 0f);

    // Use this for initialization
    public void Start()
    {
        /*base.Start();
        foreach (Transform t in transform)
        {
            if (t.gameObject.name == "WaveEffect")
                WaveEffect = t.gameObject;
            if (t.gameObject.name == "WaveEffect1")
                WaveEffect1 = t.gameObject;
        }
        waveEffectSize = WaveEffect.GetComponent<SpriteRenderer>().sprite.bounds.size.x;

    }

    // Update is called once per frame
    public override void FixedUpdate()
    {
        base.FixedUpdate();


    }



    public override void Emit()
    {
        base.Emit();
        float fractionOfTime = 1f - emitCounter / emitTime;
        float fractionOfTime1 = 1f - (emitCounter / (emitTime + 1f));
        float destScale = xRange * 2f / waveEffectSize;

        float sc = destScale * fractionOfTime;
        float sc1 = destScale * fractionOfTime1;

        if (offset.x > 0.1f)
            offset.x = 0f;
        if (offset.y > 0.1f)
            offset.y = 0f;


        offset += new Vector2(0.01f, 0.01f);

        WaveEffect.GetComponent<SpriteRenderer>().sharedMaterial.SetTextureOffset("_NoiseTex", offset);
        WaveEffect1.GetComponent<SpriteRenderer>().sharedMaterial.SetTextureOffset("_NoiseTex", offset);




       WaveEffect.transform.localScale = new Vector3(sc, sc, sc);
        WaveEffect1.transform.localScale = new Vector3(sc1, sc1, sc1);

    }

    public override void startEmitting()
    {
        base.startEmitting();

        WaveEffect.GetComponent<SpriteRenderer>().enabled = true;
        WaveEffect1.GetComponent<SpriteRenderer>().enabled = true;



    }

    public override void endEmission()
    {
        base.endEmission();

        WaveEffect.GetComponent<SpriteRenderer>().enabled = false;
        WaveEffect.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        WaveEffect1.GetComponent<SpriteRenderer>().enabled = false;
        WaveEffect1.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);


    }


    public override void scareBalthazar(float v)
    {

        base.scareBalthazar(v);

        float xSpeed = Mathf.Sign(b.transform.position.x - transform.position.x);
        float ySpeed = Mathf.Sign(b.transform.position.y - transform.position.y);
        //float smartsFactor =  2f * (1 - b.smarts/10f);


        float grounded = 1f;
        if (b.r.velocity.y < 0.2f)
            grounded = 0f;

        Vector2 force = new Vector2(xSpeed * scareFactorX, ySpeed * scareFactorY * grounded);
        if(!b.dead)
            b.applyExternalForce(force);


    */
    }

}

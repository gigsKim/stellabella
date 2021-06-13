using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlebossMove : MonoBehaviour
{
    
    public bool radordie;



    int oneShoting;
   
  
    
    

   public bool ismoveon = true;
    public bool isbreak = true;

    CtrlPlayer ct;

    bool playermove = false;

    float time = 0;
    bool die = false;


    float playermovetime = 0;

   public GameObject player;
   GameObject rador;

   public  Player_charge pc;
    public GameObject but;
    GameObject tr1;
    GameObject tr2;
    GameObject tr3;

    turet1 turet1;
    turet2 turet2;
    turet3 turet3;
    Gotonext gonext;
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player_alpha_flyver");
        ct = player.GetComponent<CtrlPlayer>();
        tr3 = GameObject.Find("turet(3)");
        tr2 = GameObject.Find("turet(2)");
        tr1 = GameObject.Find("turet(1)");
        rador = GameObject.Find("radar");



        turet3 = GameObject.Find("turet(3)").GetComponent<turet3>();
        turet2 = GameObject.Find("turet(2)").GetComponent<turet2>();
        turet1 = GameObject.Find("turet(1)").GetComponent<turet1>();
        //GetComponent<Rigidbody2D>().AddForce(new Vector3(-200, 0, 0));
        rador.SetActive(false);

        gonext = GameObject.Find("next").GetComponent<Gotonext>();
        
        pc = but.GetComponent<Player_charge>();


        go.SetActive(false);


    }
     IEnumerator move(){


        if (die == false)
        {

            tr3.GetComponent<Rigidbody2D>().AddForce(new Vector3(-330, 0, 0));
            tr2.GetComponent<Rigidbody2D>().AddForce(new Vector3(-330, 0, 0));
            tr1.GetComponent<Rigidbody2D>().AddForce(new Vector3(-330, 0, 0));
        }



        this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-330, 0, 0));
      

        time = 0;
        
        ismoveon = false;
        isbreak = true;



        yield return true;




      

        
       
}

    IEnumerator moving()
    {
        isbreak = true;
        ismoveon = true;
        yield return new WaitForSeconds(1.4f);
        rador.SetActive(true);
        yield return null;

    }



    // Update is called once per frame
    void Update()
    {

        if(turet1.boss_hp <= 0 && turet2.boss_hp <= 0 && turet3.boss_hp <= 0  && die == false)
        {
           
            die = true;
            StartCoroutine("moving");

        }

       /* if (Input.GetButtonDown("Fire1"))
        {
            isbreak = true;
            ismoveon = true;
            

        }*/

        if (ismoveon && isbreak)
        {
          // GetComponent<Rigidbody2D>().AddForce(new Vector3(-10, 0, 0));
            StartCoroutine("move");
        }


        if(ismoveon == false && isbreak  == true)
        {
            time += Time.deltaTime;
            
            if(time >= 1.5f)
            {

                if (die == false)
                {

                    tr3.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    tr2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    tr1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                }
                this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
               
                    isbreak = false;
            }
        }



        if(radordie == true)
        {
            ct.enabled = false;
            pc.enabled = false;
           
            playermove = true;
            radordie = false;
            gonext.alldie = true;
            go.SetActive(true);
        }


        if(playermove == true)
        {
            playermovetime += Time.deltaTime;
           
        }

        if (playermovetime >= 3.0f && playermove == true)
        {
            player.GetComponent<Rigidbody2D>().AddForce(new Vector3(250, 0, 0));
            playermove = false;

        }

    }
}

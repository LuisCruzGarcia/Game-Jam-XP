using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class execute : MonoBehaviour
{
    // 1-UP, 2-Down, 3-Rigth, 4-Left
    public int[] instructions;
    Button play;
    GameObject rumba;

    bool done = false;
    public float speed = 5f;
    public bool instructionLimited = false;

    
    bool[] inst = new bool[8] { false, false, false, false, false, false, false, false };

    public float waitingTime = 10f;
    float timePassed;
    bool fix = true;

    float minDist;
    public GameObject ClosestEnemy;
    public float timeToFire = 2f;
    public GameObject bullet;

 
    bool fired = false;

    int currentInstruction;
    float originalSpeed;
    int powerUpInstruction;
    public bool shieldOn = false;
    bool waterOn = false;
    bool speedOn = false;
    GameObject shieldImage;
    int shieldHealth;
    public float waterDown = 1f;

    AudioSource rumbaShoot;


    bool empty = true;

    public float back = 1.5f;
    bool backDone = false;

    bool doorOpen = false;

    public bool isDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        minDist = Mathf.Infinity;
        play = GetComponent<Button>();
        play.onClick.AddListener(executeInstructions);
        rumba = GameObject.Find("rumba");
        powerUpInstruction = 0;
        originalSpeed = speed;

        shieldImage = GameObject.Find("shield");
        shieldImage.SetActive(false);

        rumbaShoot = rumba.GetComponent<AudioSource>();

    }

    // Update is called once per frame

    void executeInstructions()
    {


        done = true;
        foreach(int instruction in instructions)
        {
            if(instruction != 0)
            {
                empty = false;
                break;
            }

            if(instruction == 0)
            {
                empty = true;
            }
        }


    }


    private void Update()
    {




        if (done && !empty)
        {

           
            //ShieldDisabler


            if (shieldOn == true && GameObject.Find("rumba").GetComponent<rumbaHealth>().health < shieldHealth)
            {
                shieldOn = false;
                
                shieldImage.SetActive(false);
                rumba.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
            }


            //1
            if (!instructionLimited && !inst[0] && fix)
            {

                executeInstruction(0);
                GameObject.Find("iSlot1").GetComponent<Image>().color = new Color(0, 0, 0);
                timePassed = timePassed + Time.deltaTime;

                currentInstruction = 0;
                resetPowerUp();

            } else if (!inst[0] && fix)
            {
                inst[0] = true;
                instructionLimited = false;
                fix = false;
                backDone = false;
            }

            //2    //hacer que este no se repita
            if (!instructionLimited && inst[0])
            {

                executeInstruction(1);
                GameObject.Find("iSlot2").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 1;
                resetPowerUp();

            }
            else if (inst[0] && instructionLimited)
            {
                inst[0] = false;


                inst[1] = true;
                instructionLimited = false;
                backDone = false;
            }

            //3
            if (!instructionLimited && inst[1])
            {
                executeInstruction(2);
                GameObject.Find("iSlot3").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 2;
                resetPowerUp();
            }
            else if (inst[1] && instructionLimited)
            {
                inst[1] = false;
                inst[2] = true;
                instructionLimited = false;
                backDone = false;
            }

            //4
            if (!instructionLimited && inst[2])
            {
                executeInstruction(3);
                GameObject.Find("iSlot4").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 3;
                resetPowerUp();
            }
            else if (inst[2] && instructionLimited)
            {
                inst[2] = false;
                inst[3] = true;
                instructionLimited = false;
                backDone = false;
            }

            //5
            if (!instructionLimited && inst[3])
            {
                executeInstruction(4);
                GameObject.Find("iSlot5").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 4;
                resetPowerUp();
            }
            else if (inst[3] && instructionLimited)
            {
                inst[3] = false;
                inst[4] = true;
                instructionLimited = false;
                backDone = false;
            }

            //6
            if (!instructionLimited && inst[4])
            {
                executeInstruction(5);
                GameObject.Find("iSlot6").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 5;
                resetPowerUp();
            }
            else if (inst[4] && instructionLimited)
            {
                inst[4] = false;
                inst[5] = true;
                instructionLimited = false;
                backDone = false;
            }

            //7
            if (!instructionLimited && inst[5])
            {
                executeInstruction(6);
                GameObject.Find("iSlot7").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 6;
                resetPowerUp();
            }
            else if (inst[5] && instructionLimited)
            {
                inst[5] = false;
                inst[6] = true;
                instructionLimited = false;
                backDone = false;
            }

            //8
            if (!instructionLimited && inst[6])
            {
                executeInstruction(7);
                GameObject.Find("iSlot8").GetComponent<Image>().color = new Color(0, 0, 0);

                currentInstruction = 7;
                resetPowerUp();
                
                

                resetInstructions();
            }
            else if (inst[6] && instructionLimited)
            {

                inst[6] = false;
                inst[7] = true;
                instructionLimited = false;
                backDone = false;

            }



        }



        




    }


    void executeInstruction(int instructionNumber)
    {
        if (instructions[instructionNumber] == 1)
        {
            if (!backDone)
            {
                rumba.transform.position = new Vector2(rumba.transform.position.x, rumba.transform.position.y - back);
                backDone = true;
            }
            
            rumba.transform.position += transform.up * Time.deltaTime * speed;
            rumba.transform.rotation = new Quaternion(0f, 0f, 90f, 0f);
        } else if (instructions[instructionNumber] == 2)
        {
            if (!backDone)
            {
                rumba.transform.position = new Vector2(rumba.transform.position.x, rumba.transform.position.y + back);
                backDone = true;
            }

            rumba.transform.position += -transform.up * Time.deltaTime * speed;
            rumba.transform.rotation = new Quaternion(0f, 0f, 270f, 0f);
        }
        else if (instructions[instructionNumber] == 3)
        {
            if (!backDone)
            {
                rumba.transform.position = new Vector2(rumba.transform.position.x - back, rumba.transform.position.y);
                backDone = true;
            }
            rumba.transform.position += transform.right * Time.deltaTime * speed;
            rumba.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        }
        else if (instructions[instructionNumber] == 4)
        {
            if (!backDone)
            {
                rumba.transform.position = new Vector2(rumba.transform.position.x + back, rumba.transform.position.y);
                backDone = true;
            }
            rumba.transform.position += -transform.right * Time.deltaTime * speed;
            rumba.transform.rotation = new Quaternion(0f, 0f, 180f, 0f);
        }
        else if (instructions[instructionNumber] == 0)
        {
            if (instructionNumber == 0)
            {
                inst[0] = true;
                instructionLimited = false;
                fix = false;
            }
            else
            {
                inst[instructionNumber] = true;
                inst[instructionNumber - 1] = false;
            }

        }
        else if (instructions[instructionNumber] == 5)
        {

            //fireInstruction

            minDist = Mathf.Infinity;
            closestTarget();
            

            if(ClosestEnemy != null)
            {
                moveRumbaAim();
                StartCoroutine(waitToFire(instructionNumber));
                rumbaShoot.Play(0);
                
                if(isDestroyed)
                {
                    ClosestEnemy = null;
                    isDestroyed = false;
                }

                
            } else
            {
                Debug.Log("error");
                if (instructionNumber == 0)
                {
                    inst[0] = true;
                    instructionLimited = false;
                    fix = false;
                }
                else
                {
                    inst[instructionNumber] = true;
                    inst[instructionNumber - 1] = false;
                }

            }
            
            fired = false;

           


        }

        else if (instructions[instructionNumber] == 6)
        {

            //openDoors
            if (instructionNumber == 0)
            {
                inst[0] = true;
                instructionLimited = false;
                fix = false;
            }
            else
            {
                inst[instructionNumber] = true;
                inst[instructionNumber - 1] = false;
                instructionLimited = false;
            }


            GameObject[] doors;
            doors = GameObject.FindGameObjectsWithTag("door");

            if (doors != null)
            {
                foreach (GameObject door in doors)
                {
                    if (!doorOpen)
                    {
                        door.transform.Rotate(0.0f, 80.0f, 0.0f, Space.Self);
                        door.transform.position = new Vector3(door.transform.position.x - 1.5f, door.transform.position.y, door.transform.position.z);
                        doorOpen = true;
                    } else
                    {
                        door.transform.Rotate(0.0f, 160.0f, 0.0f, Space.Self);
                        door.transform.position = new Vector3(door.transform.position.x + 1.5f, door.transform.position.y, door.transform.position.z);
                        doorOpen = false;
                    }
                    
                }

            }



        }

    }


    //void fixHalt()
    //{
    //    if (timePassed > waitingTime)
    //    {
    //        instructionLimited = true;
    //        timePassed = 0;
    //    }
    //}

    void closestTarget()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("enemy");

       

        foreach (GameObject enemy in enemies)
        {

            float dist = Vector2.Distance(enemy.transform.position, rumba.transform.position);

            Debug.Log(enemy.name);
            Debug.Log(dist);

            //if (isDestroyed)
            //{
            //    isDestroyed = false;
            //    minDist = Mathf.Infinity;
                
            //}

            if (dist < minDist)
            {

                ClosestEnemy = enemy;
                minDist = dist;

            }

            //float distClosest = Vector3.Distance(ClosestEnemy.transform.position, transform.position);
            //if (distClosest > minDist)
            //{
            //    minDist = distClosest;
            //}
        }

       

    }


    void moveRumbaAim()
    {
        Vector3 dir = ClosestEnemy.transform.position - rumba.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rumba.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }


    IEnumerator waitToFire(int instruction)
    {

        yield return new WaitForSeconds(timeToFire);

        if(!fired)
        {
            Instantiate(bullet, rumba.transform.position, rumba.transform.rotation);

            if (instruction == 0)
            {
                inst[0] = true;
                instructionLimited = false;
                fix = false;
            }
            else
            {
                inst[instruction] = true;
                inst[instruction - 1] = false;
                instructionLimited = false;
            }
            fired = true;
        }

        

    }


    public void speedPowerUp()
    {
        powerUpInstruction = currentInstruction + 1;
        speed = speed * 2;
        rumba.GetComponent<SpriteRenderer>().color = new Color(0, 255, 37);
        speedOn = true;
        
        
    }


    public void shield()
    {
        shieldImage.SetActive(true);
        powerUpInstruction = currentInstruction + 1;
        rumba.GetComponent<SpriteRenderer>().color = new Color(221, 0, 255);
        GameObject.Find("rumba").GetComponent<rumbaHealth>().health++;
        shieldHealth = GameObject.Find("rumba").GetComponent<rumbaHealth>().health;

    }

    public void water()
    {
        powerUpInstruction = currentInstruction + 1;
        speed = speed - waterDown;
        waterOn = true;
    }


    public void resetPowerUp()
    {
        if(currentInstruction > powerUpInstruction)
        {
            if (speedOn)
            {
                speed = originalSpeed;
                speedOn = false;
            }

            if (waterOn)
            {
                speed = originalSpeed;
                waterOn = false;
            }
            
            rumba.GetComponent<SpriteRenderer>().color = new Color(255,255,255);

            if(shieldOn == true)
            {
                shieldImage.SetActive(false);
                shieldOn = false;
                if(GameObject.Find("rumba").GetComponent<rumbaHealth>().health > 1) {

                    GameObject.Find("rumba").GetComponent<rumbaHealth>().health--;
                    shieldImage.SetActive(false);
                }
            }
        }
        
    }


    public void resetInstructions()
    {
        

        done = false;
        empty = true;

        for(int i = 0; i < inst.Length; i++)
        {
            inst[i] = false;
        }

        Debug.Log("e");

        currentInstruction = 0;

        instructionLimited = false;

        fix = true;

        backDone = false;

        GameObject.Find("iSlot1").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot2").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot3").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot4").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot5").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot6").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot7").GetComponent<Image>().color = new Color(255, 255, 255);
        GameObject.Find("iSlot8").GetComponent<Image>().color = new Color(255, 255, 255);



    }

}

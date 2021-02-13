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

    bool inst1 = false, inst2 = false, inst3 = false, inst4 = false, inst5 = false, inst6 = false, inst7 = false, inst8 = false;
    bool[] inst = new bool[8]{ false, false, false, false, false, false, false, false };

    public float waitingTime = 10f;
    float timePassed;
    bool fix = true;
  

    // Start is called before the first frame update
    void Start()
    {
        
        play = GetComponent<Button>();
        play.onClick.AddListener(executeInstructions);
        rumba = GameObject.Find("rumba");
    }

    // Update is called once per frame
   
    void executeInstructions()
    {

        done = true;

    }


    private void Update()
    {


        

        if (done)
        {

            //1
            if (!instructionLimited && !inst[0] && fix)
            {
                
                executeInstruction(0);
                
                timePassed = timePassed + Time.deltaTime;


            } else if (!inst[0] && fix)
            {
                inst[0] = true;
                instructionLimited = false;
                fix = false;
            }

            //2    //hacer que este no se repita
            if (!instructionLimited && inst[0])
            {

                executeInstruction(1);
                
            }
            else if(inst[0] && instructionLimited)
            {
                inst[0] = false;
                

                inst[1] = true;
                instructionLimited = false;
            }

            //3
            if (!instructionLimited && inst[1])
            {
                executeInstruction(2);
            }
            else if (inst[1] && instructionLimited)
            {
                inst[1] = false;
                inst[2] = true;
                instructionLimited = false;
            }

            //4
            if (!instructionLimited && inst[2])
            {
                executeInstruction(3);
            }
            else if (inst[2] && instructionLimited)
            {
                inst[2] = false;
                inst[3] = true;
                instructionLimited = false;
            }

            //5
            if (!instructionLimited && inst[3])
            {
                executeInstruction(4);
            }
            else if (inst[3] && instructionLimited)
            {
                inst[3] = false;
                inst[4] = true;
                instructionLimited = false;
            }

            //6
            if (!instructionLimited && inst[4])
            {
                executeInstruction(5);
            }
            else if (inst[4] && instructionLimited)
            {
                inst[4] = false;
                inst[5] = true;
                instructionLimited = false;
            }

            //7
            if (!instructionLimited && inst[5])
            {
                executeInstruction(6);
            }
            else if (inst[5] && instructionLimited)
            {
                inst[5] = false;
                inst[6] = true;
                instructionLimited = false;
            }

            //8
            if (!instructionLimited && inst[6])
            {
                executeInstruction(7);
            }
            else if (inst[6] && instructionLimited)
            {
                inst[6] = false;
                inst[7] = true;
                instructionLimited = false;
            }


            
        }



    }


    void executeInstruction(int instructionNumber)
    {
        if (instructions[instructionNumber] == 1)
        {
            rumba.transform.position += transform.up * Time.deltaTime * speed;
        } else if(instructions[instructionNumber] == 2)
        {
            rumba.transform.position += -transform.up * Time.deltaTime * speed;
        }
        else if (instructions[instructionNumber] == 3)
        {
            rumba.transform.position += transform.right * Time.deltaTime * speed;
        }
        else if (instructions[instructionNumber] == 4)
        {
            rumba.transform.position += -transform.right * Time.deltaTime * speed;
        }
        else if (instructions[instructionNumber] == 0)
        {
            inst[instructionNumber] = true;
            inst[instructionNumber - 1] = false;
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


    

}

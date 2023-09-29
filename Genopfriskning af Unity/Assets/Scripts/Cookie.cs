using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{

    // Variable =type name
    /* 
       int = whole numbers like -5, -1, 0, 1, 5
       float = decimal numbers like -5.5, -1.1, 1.1, 5.5
    */
    public bool hasPressedSpace;
    public int score = 0;
    public float decimalNumber = 2.4f;
    public string mText = "Hello there ;)";
    bool test;

    // Start is called before the first frame update

    /* 
       void = return value (no specific return)
       name = Start
       optionally inputs () = in this case no inputs 
    */

    void Start()
    {
        Debug.Log("this happends only once at the start");
        PrintScore();
        print(MultiplyByTwo(2));
        print(MultiplyByTwo(5));

        print(Multiply(5, 3));
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This happends every frame");
        hasPressedSpace = Input.GetKeyDown(KeyCode.Space);
        if (hasPressedSpace)
        {
            /*
            score = score + 1;
            or
            score++
            */
            score = score + 1;
        }

        if (score == 10)
        {
            print("Congratulation you got 10 cookies, yay!");
            PrintScore();
        }

        

    }

    private void FixedUpdate()
    {
        score++;
    }

    public void PrintScore()
    {
        print(score);
        return;
    }

    int MultiplyByTwo(int inputNumber)
    {
        int result = inputNumber * 2;
        return result;
    }

    float Multiply(float n1, float n2)
    {
        return n1 * n2;
    }

}

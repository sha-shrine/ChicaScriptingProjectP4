using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;

    // This is a private variable that is only accessible within this class
    private AnotherClass myOtherClass;
    // Start is called before the first frame update
    void Start()
    {
        //changing the value of alpha to 29
        alpha = 29;

        //creating an instance of AnotherClass
        myOtherClass = new AnotherClass();

        //i am going to use the method from AnotherClass to add the value of alpha and the value of apples together
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens + crayons * alpha;
        Debug.Log(answer);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}

using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour
{
    private void Start()
    {
        //this line is here to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
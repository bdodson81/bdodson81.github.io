using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGameObject : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        ShapeFlyweightFactory newshape = new ShapeFlyweightFactory();
        newshape.CreateShape("cube", "small", Color.blue);
        newshape.CreateShape("sphere", "small", Color.blue);
        newshape.CreateShape("cylinder", "small", Color.blue);

        newshape.CreateShape("cube", "medium", Color.blue);
        newshape.CreateShape("sphere", "medium", Color.blue);
        newshape.CreateShape("cylinder", "medium", Color.blue);

        newshape.CreateShape("sphere", "large", Color.blue);
        newshape.CreateShape("cylinder", "large", Color.blue);
        newshape.CreateShape("cube", "large", Color.blue);

        newshape.CreateShape("cube", "small", Color.red);
        newshape.CreateShape("sphere", "small", Color.red);
        newshape.CreateShape("cylinder", "small", Color.red);

        newshape.CreateShape("cube", "medium", Color.red);
        newshape.CreateShape("sphere", "medium", Color.red);
        newshape.CreateShape("cylinder", "medium", Color.red);

        newshape.CreateShape("sphere", "large", Color.red);
        newshape.CreateShape("cylinder", "large", Color.red);
        newshape.CreateShape("cube", "large", Color.red);

        newshape.CreateShape("cube", "small", Color.green);
        newshape.CreateShape("sphere", "small", Color.green);
        newshape.CreateShape("cylinder", "small", Color.green);

        newshape.CreateShape("cube", "medium", Color.green);
        newshape.CreateShape("sphere", "medium", Color.green);
        newshape.CreateShape("cylinder", "medium", Color.green);

        newshape.CreateShape("sphere", "large", Color.green);
        newshape.CreateShape("cylinder", "large", Color.green);
        newshape.CreateShape("cube", "large", Color.green);

    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}

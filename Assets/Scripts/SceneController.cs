﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SceneController : MonoBehaviour
{

    public List<Shape> gameShapes;
    public Dictionary<string, Shape> shapeDictionary;

    public Queue<Shape> shapeQueue;

    public Stack<Shape> ShapeStack;

    // Start is called before the first frame update
    void Start()
    {
        shapeQueue = new Queue<Shape>();

        shapeDictionary = new Dictionary<string, Shape>();

        ShapeStack = new Stack<Shape>();

        foreach(Shape shape in gameShapes)
        {
            shapeDictionary.Add(shape.Name, shape);
        }
        shapeQueue.Enqueue(shapeDictionary["Triangle"]);
        shapeQueue.Enqueue(shapeDictionary["Square"]);
        shapeQueue.Enqueue(shapeDictionary["Octagon"]);
        shapeQueue.Enqueue(shapeDictionary["Circle"]);

        ShapeStack.Push(shapeDictionary["Triangle"]);
        ShapeStack.Push(shapeDictionary["Square"]);
        ShapeStack.Push(shapeDictionary["Octagon"]);
        ShapeStack.Push(shapeDictionary["Circle"]);

    }
    private void SetRedByName (string shapeName)
    {
        shapeDictionary[shapeName].SetColor(Color.red);
    }
    //private void ListExample()
    //{
    //    string[] shapes = { "circle", "square", "triangle", "octagon" };
    //    List<string> moreShapes;
    //    moreShapes = new List<string> { "circle", "square", "triangle", "octagon" };

    //    moreShapes.Add("rectangle");
    //    moreShapes.Insert(2, "diamond");
    //    moreShapes.Sort();

    //    for(int i = 0; i < moreShapes.Count; i++)
    //    {
    //        moreShapes[i] = moreShapes[i].ToUpper();
    //        Debug.Log(moreShapes[i]);
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(ShapeStack.Count > 0)
            {
            Shape shape = ShapeStack.Pop();
            shape.SetColor(Color.green);
        }
        else
        {
            Debug.Log("The stack is Empty!");
        }
        }
    }
}

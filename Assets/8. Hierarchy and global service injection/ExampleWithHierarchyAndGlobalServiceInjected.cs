﻿using UnityEngine;
using System.Collections;

/// <summary>
/// An example MonoBehaviour that has a global service injected.
/// </summary>
public class ExampleWithHierarchyAndGlobalServiceInjected : MonoBehaviour
{
    [Inject]
    public ExampleDependency ExampleDependency { get; set; }

    [Inject]
    public ExampleGlobalService ExampleGlobalService { get; set; }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

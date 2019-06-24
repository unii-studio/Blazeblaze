﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

  public Animator animator;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
    Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
    transform.position = transform.position + horizontal * Time.deltaTime;
  }
}

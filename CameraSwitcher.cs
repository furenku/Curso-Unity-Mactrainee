using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour {

  public CameraScript[] cameraScripts;

  public int activeCamera = 0;
  private int lastCamera = 0;

  void Start() {

    ChangeCamera( activeCamera );


  }

  void Update()
  {
    if (activeCamera != lastCamera )
    {
      lastCamera = activeCamera;
      ChangeCamera(activeCamera);
    }

    if (Input.GetKeyDown("1")) ChangeCamera(0);
    if (Input.GetKeyDown("2")) ChangeCamera(1);
    if (Input.GetKeyDown("3")) ChangeCamera(2);
    if (Input.GetKeyDown("4")) ChangeCamera(3);

  }

  void ChangeCamera( int _selectedCamera ) {

    if( cameraScripts[ _selectedCamera ] != null ) {

      foreach( CameraScript cadaScript in cameraScripts ) {

        if( cadaScript != null ) {
          cadaScript.enabled = false;
        }

      }

      cameraScripts[ _selectedCamera ].enabled = true;
    }

  }



}

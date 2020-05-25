using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Chess : MonoBehaviour
{
    private Vector3 startPosition;

    GameObject ARCam;

    ARSessionOrigin m_SessionOrigin;

    // Start is called before the first frame update
    void Start()
    {
        m_SessionOrigin = gameObject.Find("AR Session Origin").GetComponent<ARSessionOrigin>();
        ARCam = m_SessionOrigin.transform.Find("AR Camera").gameObject;
        transform.parent = ARCam.transform;
        NewChess();
    }

    void NewChess()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;
            ChessMove();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            CheckPosition();
        }
    }
}
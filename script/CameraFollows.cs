using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{

    public Transform followTransform;
   /*
    public BoxCollider2D mapBounds;

    private float xMin, xMax, yMin, yMax;
    private float camY,camX;
    private float camOrthsize;
    private float cameraRatio;
    private Camera mainCam;
    private Vector3 smoothPos;
    public float smoothSpeed = 0.5f;

    private void Start()
    {
        xMin = mapBounds.bounds.min.x;
        xMax = mapBounds.bounds.max.x;
        yMin = mapBounds.bounds.min.y;
        yMax = mapBounds.bounds.max.y;
        mainCam = GetComponent<Camera>();
        camOrthsize = mainCam.orthographicSize;
        cameraRatio = (xMax + camOrthsize) / 2.0f;
    }*/
    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        camY = Mathf.Clamp(followTransform.position.y, yMin + camOrthsize, yMax - camOrthsize);
        camX = Mathf.Clamp(followTransform.position.x, xMin + cameraRatio, xMax - cameraRatio);
        smoothPos = Vector3.Lerp(this.transform.position, new Vector3(camX, camY, this.transform.position.z), smoothSpeed);
        */
        this.transform.position = new Vector3(followTransform.position.x,followTransform.position.y,this.transform.position.z);
        
        
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private GameObject player;

    private float positionX;
    private float positionY;

    private Vector2 currentVelocity;

    public float smoothX;
    public float smoothY;

    public bool border;

    public float minX;
    public float maxX;

    public float minY;
    public float maxY;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("ForCam");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("ForCam");
        }
        else
        {
            SmoothCamera();
        }
        if (border == true)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
        }

    }

    void SmoothCamera()
    {
        positionX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref currentVelocity.x, smoothX);
        positionY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref currentVelocity.y, smoothY);
        transform.position = new Vector3(positionX, positionY, transform.position.z);
    }
}
*/
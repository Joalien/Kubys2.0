// using UnityEngine;
//
// public class MinimapCameraScript : MonoBehaviour
// {
//     [SerializeField]
//     [Range(5, 50)]
//     private int distanceFromPlayer = 20;
//
//     private Transform _mainPlayer;
//
//     private Camera _mainCamera;
//
//     private Camera _minimapCamera;
//     // Start is called before the first frame update
//     void Start()
//     {
//         _mainPlayer = GameObject.Find("MyPlayer").transform;
//         _mainCamera = Camera.main;
//         _minimapCamera = GetComponent<Camera>();
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         Vector3 futurePosition = _mainPlayer.transform.position;
//         futurePosition.y = transform.position.y;
//         transform.position = futurePosition;
//
//         _minimapCamera.orthographicSize = distanceFromPlayer;
//
//         transform.rotation = Quaternion.Euler(90f, _mainCamera.transform.eulerAngles.y, 0f);
//     }
// }

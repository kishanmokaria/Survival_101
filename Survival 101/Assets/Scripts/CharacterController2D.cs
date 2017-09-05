using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // include so we can load new scenes

public class CharacterController2D : MonoBehaviour {

		public float moveSpeed = 3f;
		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update ()
		{
			//Moves Forward and back along z axis                           //Up/Down
			transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical")* moveSpeed);
			//Moves Left and right along x Axis                               //Left/Right
			transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* moveSpeed);      
		}
	}
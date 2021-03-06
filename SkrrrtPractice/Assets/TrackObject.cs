﻿using UnityEngine;
using System.Collections;

public class TrackObject : MonoBehaviour {

	public Transform target;
	public float distanceUp;
	public float distanceBack;
	public float minimumHeight;

	private Vector3 positionVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		Vector3 newPosition = target.position + (target.forward * distanceBack);
		newPosition.y = Mathf.Max (newPosition.y + distanceUp, minimumHeight);

		transform.position = Vector3.SmoothDamp (transform.position, newPosition, ref positionVelocity, .18f);

		Vector3 focalPoint = target.position + (target.forward * 5);
		transform.LookAt (focalPoint);
	}
}

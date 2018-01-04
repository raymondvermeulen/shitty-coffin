using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBoxObscure : MonoBehaviour {
    public Transform cameraTransform;
    private BoxCollider boxCollider;
    public GameObject toggleTarget;
    float timing = 0f;

    void OnEnable ()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
	// Update is called once per frame
	void Update () {
        timing += Time.deltaTime;
		if (timing > 15f && boxCollider.bounds.Contains(cameraTransform.position))
        {
            toggleTarget.SetActive(true);
        } else
        {
            toggleTarget.SetActive(false);
        }
	}
}

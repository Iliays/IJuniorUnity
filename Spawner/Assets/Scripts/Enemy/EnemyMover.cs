using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

	private void Update()
	{
		transform.Translate(Vector3.right * _speed * Time.deltaTime);
	}
}
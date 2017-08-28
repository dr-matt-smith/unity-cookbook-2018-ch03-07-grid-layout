using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	private PlayerModel playerModel;

	void Awake()
	{
		playerModel = GetComponent<PlayerModel>();
	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		if(hit.CompareTag("Star")){
			playerModel.AddStar();
			Destroy(hit.gameObject);
		}
	}
}

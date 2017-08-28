using UnityEngine;
using System.Collections;

public class PlayerInventoryScene2 : MonoBehaviour 
{
	private int starTotal = 0;
	private PlayerInventoryDisplayScene2 playerInventoryDisplay;

	void Awake()
	{
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplayScene2>();
	}

	void Start()
	{
		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		if(hit.CompareTag("Star")){
			AddStar();
			Destroy(hit.gameObject);
		}
	}

	private void AddStar()
	{
		starTotal++;
		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}
}

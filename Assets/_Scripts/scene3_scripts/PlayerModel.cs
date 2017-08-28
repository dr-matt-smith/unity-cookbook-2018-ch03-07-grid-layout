using UnityEngine;
using System.Collections;

public class PlayerModel : MonoBehaviour 
{
	private int starTotal = 0;
	private PlayerInventoryDisplayScene3 playerInventoryDisplay;

	void Awake()
	{
		playerInventoryDisplay = GetComponent<PlayerInventoryDisplayScene3>();
	}

	void Start()
	{
		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}

	public void AddStar()
	{
		starTotal++;
		playerInventoryDisplay.OnChangeStarTotal(starTotal);
	}
}

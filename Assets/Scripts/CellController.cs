using UnityEngine;
using System.Collections;

public class CellController : MonoBehaviour {

	private SpriteRenderer spRender;

	public Sprite xPiece;
	public Sprite yPiece;

	void Awake()
	{
		spRender = GetComponent<SpriteRenderer>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (spRender.sprite == null)
		{
			spRender.sprite = xPiece;
		}
	}
}

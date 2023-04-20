using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlushController : MonoBehaviour
{
	Image img;

	void Start()
	{
		img = GetComponent<Image>();
		img.color = Color.clear;
	}

	void Update()
	{
		this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
	}

	public void Flash()
	{
		this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
	}

	public void Flash(float r, float g, float b, float a)
	{
		this.img.color = new Color(r, g, b, a);
	}
}

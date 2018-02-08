﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetter : MonoBehaviour {
	public PlayerController player;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Item") {
			player.TakeItem (other.GetComponent<Item> ());
		}
	}
}

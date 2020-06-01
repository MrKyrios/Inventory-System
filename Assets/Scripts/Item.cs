using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Item", menuName = "Item", order = 0)]
public class Item : ScriptableObject
{
	public new string name = string.Empty;
	public int id = 0;
	public int maxStack = 64;
}
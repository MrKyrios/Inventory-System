using UnityEngine;

public class Test : MonoBehaviour
{
	[SerializeField] private Item item = null;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Inventory.Instance.Add(item, 1);
		}
	}
}
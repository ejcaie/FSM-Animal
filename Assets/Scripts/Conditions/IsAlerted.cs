using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class IsAlerted : ConditionTask {

		public BBParameter<Transform> playerCursor;
		public BBParameter<bool> hasTarget;

		protected override bool OnCheck()
		{
			
			if (Input.GetMouseButtonDown(0))
			{
				Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(mouseRay, out RaycastHit hitInfo) )
				{
					hasTarget = false;
					playerCursor.value.position = hitInfo.point;
					return true;
				}
			}
			return false;
		}
	}
}
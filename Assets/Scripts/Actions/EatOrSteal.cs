using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class EatOrSteal : ActionTask
	{

		public BBParameter<bool> steal;
		public int choice;

		protected override void OnExecute()
		{
			choice = Random.Range(1, 3);
		}

		protected override void OnUpdate()
		{
            if (choice == 1)
            {
                steal.value = true;
            }
            else steal.value = false;
        }
	}
}
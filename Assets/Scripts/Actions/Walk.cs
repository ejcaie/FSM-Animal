using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Walk : ActionTask {

		public NavMeshAgent navAgent;
		public BBParameter<Transform> targetLocation;
		public BBParameter<Transform> denLocation;
		public BBParameter<Transform> foodLocation;
		public BBParameter<bool> atDen;
		public BBParameter<bool> atFood;

		private Vector3 distanceToTarget;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			navAgent.SetDestination(targetLocation.value.position);

			distanceToTarget = navAgent.transform.position - targetLocation.value.position;

			if (distanceToTarget.magnitude <= 0.5)
			{
				if (targetLocation.value == denLocation.value)
				{
					atDen.value = true;
				}

				if (targetLocation.value == foodLocation.value) 
				{
					atFood.value = true;
				}
			}
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}
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


		protected override void OnUpdate() {

			navAgent.SetDestination(targetLocation.value.position);

			distanceToTarget = navAgent.transform.position - targetLocation.value.position;

			if (distanceToTarget.magnitude <= 0.5 && targetLocation.value == denLocation.value) atDen.value = true;

			if (distanceToTarget.magnitude <= 0.5 && targetLocation.value == foodLocation.value) atFood.value = true;
		}
	}
}
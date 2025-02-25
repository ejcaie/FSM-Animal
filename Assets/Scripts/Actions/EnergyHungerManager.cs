using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class EnergyHungerManager : ActionTask {

		public BBParameter<float> hunger;
		public BBParameter<float> energy;
		public Collider trigger;

		protected override void OnUpdate() {
			
			if (hunger.value >= 0)
			{
				hunger.value = hunger.value - 1 * Time.deltaTime;

				if (hunger.value < 0.1) hunger.value = 0;
			}

			if (energy.value >= 0)
			{
				energy.value = energy.value - 1 * Time.deltaTime;

                if (energy.value < 0.1) energy.value = 0;
            }
		}
	}
}
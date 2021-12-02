using System.Collections;
using UnityEngine;

#pragma warning disable 649
namespace Assets.Imported.Standard_Assets.Vehicles.Car.Scripts
{
    public class SkidTrail : MonoBehaviour
    {
        [SerializeField] private float m_PersistTime;


        private IEnumerator Start()
        {
			while (true)
            {
                yield return null;

                if (transform.parent.parent == null)
                {
					Destroy(gameObject, m_PersistTime);
                }
            }
        }
    }
}
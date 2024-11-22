using UnityEngine;

public class AreaTrigger : MonoBehaviour
{
    private GameObject firstObject = null;  // �lk giren nesne
    private GameObject secondObject = null;  // �kinci giren nesne
    public float throwForce;  
    public Vector3 throwDirection;  

    // Bu fonksiyon, bir nesne alana girdi�inde �al���r
    private void OnTriggerEnter(Collider other)
    {
        // E�er birinci nesne alana girdiyse kaydet
        if (firstObject == null)
        {
            firstObject = other.gameObject;
        }
        // E�er ikinci nesne alana girdiyse, birinci nesne alanda ise, onu f�rlat
        else if (secondObject == null && other.gameObject != firstObject && firstObject != null)
        {
            secondObject = other.gameObject;
            ThrowSecondObject();
        }
    }

    // �kinci nesneyi f�rlatma i�lemi
    private void ThrowSecondObject()
    {
        if (secondObject != null)
        {
            Rigidbody rb = secondObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);  // Kuvvet uygula
            }
        }

        // Nesneyi f�rlatt�ktan sonra s�f�rla
        secondObject = null;
    }
}

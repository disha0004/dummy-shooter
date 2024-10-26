using UnityEngine;

public class TargetDummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;
    [SerializeField] private int pointsForKill = 10;  // Points awarded for destroying the dummy

    private void OnCollisionEnter(Collision other)
    {
        // Check if the dummy is hit by an object tagged as "Weapon"
        if (other.gameObject.CompareTag("Weapon"))
        {
            dummyAnimator.SetTrigger("Death");  // Play the death animation
            GetComponent<BoxCollider>().enabled = false;  // Disable further collisions

            // Add points using the ScoreManager's AddPoints method
            ScoreManager.instance.AddPoints(pointsForKill);
        }
    }

    public void ActivateDummy()
    {
        dummyAnimator.SetTrigger("Activate");  // Trigger dummy activation animation
    }
}

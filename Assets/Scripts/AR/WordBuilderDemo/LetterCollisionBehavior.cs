using System.Collections;
using UnityEngine;

public class LetterCollisionBehavior : MonoBehaviour
{
    LetterCardBehavior letterBehavior;
    bool triggerConnect = true;

    // Start is called before the first frame update
    void Start()
    {
        //get letter behavior 2 parents above in image target
        letterBehavior = gameObject.transform.parent.GetComponentInParent<LetterCardBehavior>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerConnect)
        {
            //find word and send back to letterCard Behavior
            letterBehavior.WordConnect();
            triggerConnect = false;
        }
    }

    IEnumerator SoundWait()
    {
        yield return new WaitForSeconds(2.0f);
        triggerConnect = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpawn : MonoBehaviour
{
    LetterCardBehavior letterBehavior;

    private void OnEnable()
    {
        letterBehavior = gameObject.GetComponentInParent<LetterCardBehavior>();
        letterBehavior.letterSpawn();
    }
}

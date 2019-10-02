using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHelper : MonoBehaviour {
    
    public enum AnimationType { None, Rotate, SetLookAtCam };
    public GameObject AnimatableGameObject;

    bool loopAnim = true;
    public AnimationType animationType;
    float x;
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void OnEnable() {
        loopAnim = true;
        x = 0.0f;
        if(animationType != AnimationType.None) StartCoroutine(animateObject(animationType));
    }
    private void OnDisable()
    {
        loopAnim = false;
    }

    IEnumerator animateObject(AnimationType type)
    {
        while (loopAnim) { 
            if(animationType == AnimationType.Rotate)
            {
                x += Time.deltaTime*80f;
                transform.localRotation = Quaternion.Euler(gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, x);
            }
            if (animationType == AnimationType.SetLookAtCam)
            {
                transform.LookAt(Camera.main.transform.position, transform.up);
                loopAnim = false;
            }
            yield return new WaitForSeconds(.06f);
        }
    }

    /// <summary>
    /// run animation sent through string
    /// </summary>
    public void TriggerAnimation (string selectedAnimation) {
        anim = gameObject.GetComponent<Animator>();
        anim.Play(selectedAnimation);
    }

    /// <summary>
    /// run animation sent through string
    /// </summary>
    public void TriggerOtherGameObjectAnimation(string selectedAnimation)
    {
        anim = AnimatableGameObject.GetComponent<Animator>();
        anim.Play(selectedAnimation);
    }

    /// <summary>
    /// Activate AnimatableGameObject
    /// </summary>
    public void ActivateAnimatableGameObject()
    {
        AnimatableGameObject.SetActive(true);
    }
}

using System.Collections;
using UnityEngine;

public class MovimientoDeBotella : MonoBehaviour
{
    Vector3 goalPos = new Vector3(0, 0, 0);
    Vector3 initialPos;
    public GameObject ultimaBotella;
    float reinicioPos;
    private void Start()
    {
        reinicioPos = ultimaBotella.transform.localPosition.x;
            
    }
    public void Izquierda()
    {
        initialPos = transform.localPosition;

        StartCoroutine("MoverIzquierda");
    }

    IEnumerator MoverIzquierda()
    {
        goalPos = new Vector3(initialPos.x - 5f, initialPos.y, initialPos.z);
        if(goalPos.x < -15)
        {
            goalPos =  new Vector3(initialPos.x + 15f, initialPos.y, initialPos.z);
            initialPos = new Vector3(5, 0, 0);
        }
        float speed = 0.0f;
        print(goalPos);
        while (speed < 1.0)
        {
            transform.localPosition = Vector3.Lerp(initialPos, goalPos, speed);
            speed += .05f;
            yield return new WaitForSeconds(.02f);
        }
        transform.localPosition = goalPos;

    }

}

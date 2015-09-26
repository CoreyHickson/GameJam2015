using UnityEngine;
using System.Collections;

public class initialization : MonoBehaviour {

    // Use this for initialization
    void Start () {
        StartCoroutine(waitRandom());
    }

    // A callable coroutine which waits between 3f and 10f seconds
    IEnumerator waitRandom()
    {
        float randomSeconds = Random.Range(3.0f, 10.0f);
        yield return new WaitForSeconds(randomSeconds);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
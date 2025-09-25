using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        //hits += 1;

        if(other.gameObject.tag != "Hit")
        {
            hits += 1;
            //Debug.Log("Something hit me!");
            Debug.Log("You've bumped into a thing this many times: " + hits);
            //Debug.Log($"You've bumped into a thing this many times: {hits}");
        }

    }
}

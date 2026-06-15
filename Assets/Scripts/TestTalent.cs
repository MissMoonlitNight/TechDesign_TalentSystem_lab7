using UnityEngine;
public class TestTalent : MonoBehaviour
{
    public TalentData testTalent; 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (TalentManager.Instance != null && testTalent != null)
            {
                TalentManager.Instance.LearnTalent(testTalent);
            }
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

public class UI_TestGraftButton : MonoBehaviour
{
    public Button graftButton;

    public MySkillTree skillTreeManager; // MySkillTree 오브젝트 연결
    public UI_TreeNode sourceNode; // 붙일 가지
    public UI_TreeNode targetNode; // 붙이는 위치

    private void Start()
    {
        //graftButton.onClick.AddListener(() =>
        //{
        //    skillTreeManager.GraftBranch(sourceNode, targetNode);
        //    Debug.Log($"[GRAFT] {sourceNode.name} -> {targetNode.name}");
        //});
        graftButton.onClick.AddListener(TestBranch);
    }

    void TestBranch()
    {
        sourceNode.GetComponent<Canvas>().enabled = true;
    }
    
}

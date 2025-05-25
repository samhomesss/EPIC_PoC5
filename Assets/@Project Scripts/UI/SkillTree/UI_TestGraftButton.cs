using UnityEngine;
using UnityEngine.UI;

public class UI_TestGraftButton : MonoBehaviour
{
    public Button graftButton;

    public MySkillTree skillTreeManager; // MySkillTree ������Ʈ ����
    public UI_TreeNode sourceNode; // ���� ����
    public UI_TreeNode targetNode; // ���̴� ��ġ

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

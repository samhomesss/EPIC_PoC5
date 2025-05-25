using System.Collections.Generic;
using UnityEngine;

public class MySkillTree : MonoBehaviour
{
    public List<UI_TreeNode> ui_TreeNodes;

    private void Start()
    {
        Managers.Game.OnGetWaterEvent += GrowUPTree;
    }

    void GrowUPTree()
    {
        List<UI_TreeNode> openableNodes = new List<UI_TreeNode>();

        // isCanOpen�� ��常 ����Ʈ�� �߰�
        foreach (var item in ui_TreeNodes)
        {
            if (item.isCanOpen && !item.gameObject.GetComponent<Canvas>().enabled) // �̹� �����ִ� �� ����
            {
                openableNodes.Add(item);
            }
        }

        foreach (var item in openableNodes)
        {
            Debug.Log(item.name);
        }

        // ����Ʈ�� ��尡 �ִٸ� �������� �ϳ� �����ؼ� Canvas Ȱ��ȭ
        if (openableNodes.Count > 0)
        {
            int randIndex = Random.Range(0, openableNodes.Count);
            openableNodes[randIndex].gameObject.GetComponent<Canvas>().enabled = true;
        }
    }
}

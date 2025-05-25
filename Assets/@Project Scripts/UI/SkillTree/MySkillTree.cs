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

        // isCanOpen인 노드만 리스트에 추가
        foreach (var item in ui_TreeNodes)
        {
            if (item.isCanOpen && !item.gameObject.GetComponent<Canvas>().enabled) // 이미 열려있는 건 제외
            {
                openableNodes.Add(item);
            }
        }

        foreach (var item in openableNodes)
        {
            Debug.Log(item.name);
        }

        // 리스트에 노드가 있다면 랜덤으로 하나 선택해서 Canvas 활성화
        if (openableNodes.Count > 0)
        {
            int randIndex = Random.Range(0, openableNodes.Count);
            openableNodes[randIndex].gameObject.GetComponent<Canvas>().enabled = true;
        }
    }
}

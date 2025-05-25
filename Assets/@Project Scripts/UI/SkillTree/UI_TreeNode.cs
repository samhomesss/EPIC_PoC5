using UnityEngine;
using UnityEngine.UI;

public class UI_TreeNode : UI_Scene
{
    enum Buttons
    {
        RootBG,
    }

    public Canvas parentNode; // 부모 노드 
    public Canvas[] childrenNode; // 자식 노드 -> 부모 노드를 가지치기 했을때 잘려나가야 할 노드들 

    public bool isCanOpen; // 부모노드가 활성화 되어 있을 때 성장 할수 있는 가지를 나타냄
    public bool isGrow; // 현재 해당 노드가 성장 했는지를 말함 

    Button _rootButton;

    public override bool Init()
    {
        if (base.Init() == false)
            return false;

        BindButtons(typeof(Buttons));
        _rootButton = GetButton((int)Buttons.RootBG);
        _rootButton.onClick.AddListener(BranchCut);
        return true;
    }


    private void Update()
    {
        if (parentNode.enabled) // 부모 노드가 활성화 되었을 때
        {
            isCanOpen = true;
        }
        else
        {
            isCanOpen = false;

            for (int i = 0; i < childrenNode.Length; i++)
            {
                childrenNode[i].enabled = false;
            }
        }
    }

    void BranchCut()
    {
        isCanOpen = true;
        gameObject.GetComponent<Canvas>().enabled = false;
    }

}

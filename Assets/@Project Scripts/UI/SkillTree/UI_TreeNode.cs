using UnityEngine;
using UnityEngine.UI;

public class UI_TreeNode : UI_Scene
{
    enum Buttons
    {
        RootBG,
    }

    public Canvas parentNode; // �θ� ��� 
    public Canvas[] childrenNode; // �ڽ� ��� -> �θ� ��带 ����ġ�� ������ �߷������� �� ���� 

    public bool isCanOpen; // �θ��尡 Ȱ��ȭ �Ǿ� ���� �� ���� �Ҽ� �ִ� ������ ��Ÿ��
    public bool isGrow; // ���� �ش� ��尡 ���� �ߴ����� ���� 

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
        if (parentNode.enabled) // �θ� ��尡 Ȱ��ȭ �Ǿ��� ��
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

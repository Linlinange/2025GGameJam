using UnityEngine;
using QFramework;

public class AbilityController : ViewController
{
    public LevelSettings mLevelSettings;

    public int ʣ�������������;
    public int ѡ������; // index of ���������б�

    public void Awake()
    {
        ʣ������������� = mLevelSettings.�ܿ�����������;
    }

    private void OnGUI()
    {
        IMGUIHelper.SetDesignResolution(960, 640);
        string �������� = "";
        foreach (var item in mLevelSettings.���������б�)
        {
            int num = (int)item;
            �������� += " " + AblilityBase.������[num];
        }
        GUILayout.Label("�������� " + ��������);
        GUILayout.Label("ѡ������ " + AblilityBase.������[ѡ������]);
        GUILayout.Label("�ܿ�����������:" + mLevelSettings.�ܿ�����������);
    }
    public void Update()
    {

    }
}

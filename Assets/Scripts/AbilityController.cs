using UnityEngine;
using QFramework;

public class AbilityController : ViewController
{
    public LevelSettings mLevelSettings;

    public int ʣ�������������;
    public ���� ѡ������;

    public void Awake()
    {
        ʣ������������� = mLevelSettings.�ܿ�����������;
    }

    private void OnGUI()
    {
        IMGUIHelper.SetDesignResolution(960, 640);
        GUILayout.Label(text: "��ǰ���������б�" + mLevelSettings.���������б�);
        GUILayout.Label("�ܿ�����������:" + mLevelSettings.�ܿ�����������);
    }
    public void Update()
    {

    }

    public void UseAbility()
    {
    
    }

}

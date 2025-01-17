using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static PlayerInput PlayerInput;
    public �ƶ� Player;
    public AbilityController Ability;

    #region 2Dƽ̨�ƶ�
    public static Vector2 Movement; // �ƶ�����
    public static bool JumpWasPressed; // ��Ծ�Ƿ���
    public static bool JumpIsHeld; // ��Ծ�Ƿ�ס
    public static bool JumpWasReleased; // ��Ծ�Ƿ��ͷ�
    public static bool RunIsHeld; // �ܲ��Ƿ�ס

    private InputAction _moveAction;
    private InputAction _jumpAction;
    private InputAction _runAction;
    #endregion

    #region ����ѡ��
    private InputAction _chooseAction;
    private int selectedIndex = 0;
    #endregion

    private void Awake()
    {
        Ability = GameObject.FindObjectOfType<AbilityController>();
        PlayerInput = GetComponent<PlayerInput>();

        #region 2Dƽ̨�ƶ�
        _moveAction = PlayerInput.actions["Move"];
        _jumpAction = PlayerInput.actions["Jump"];
        _runAction = PlayerInput.actions["Run"];
        #endregion

        #region ����ѡ��
        _chooseAction = PlayerInput.actions["choose"];
        #endregion
    }

    void Update()
    {
        #region 2Dƽ̨�ƶ�
        Player.Movement = _moveAction.ReadValue<Vector2>();

        Player.JumpWasPressed = _jumpAction.WasPressedThisFrame();
        Player.JumpIsHeld = _jumpAction.IsPressed();
        Player.JumpWasReleased = _jumpAction.WasReleasedThisFrame();

        Player.RunIsHeld = _runAction.IsPressed();
        #endregion

        #region ����ѡ��
        if (_chooseAction.WasPressedThisFrame())
        {
            Key key = _chooseAction.ReadValue<Key>();

            switch (key)
            {
                case Key.Digit1:
                    selectedIndex = 0;
                    break;
                case Key.Digit2:
                    selectedIndex = 1;
                    break;
                case Key.Digit3:
                    selectedIndex = 2;
                    break;
            }
        }

        if (selectedIndex >= 0 && selectedIndex < Ability.mLevelSettings.���������б�.Count)
        {
            Ability.ѡ������ = selectedIndex;
        }
    }

    #endregion
}


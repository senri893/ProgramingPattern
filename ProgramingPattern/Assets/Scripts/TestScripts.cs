using UnityEngine;

/// <summary>
/// �R���\�[�����O�ɕ������\������N���X
/// </summary>
public class TestScripts : MonoBehaviour
{
    /// <summary>
    /// �Q�[���J�n���ɏ���
    /// </summary>
    private void Start()
    {
        //int�^�̃��[�J���ϐ��ɐ��l�������ĎO�����R���}�����镶����𐶐����郁�\�b�h�Ɉ����Ƃ��đ��
        int a = 123456789;
        //�A���Ă�������������[�J���ϐ��ɕێ�
        string b = UIUtility.NumberFormatter(a);

        //float�^�̃��[�J���ϐ��ɐ��l�������ăp�[�Z���g�\���ɂ��郁�\�b�h�ɑ��
        float c = 0.45286f;
        //�A���Ă�������������[�J���ϐ��ɕێ�
        string d = UIUtility.ConvertPercent(c);

        //�R���\�[���Ƀ��O�Ƃ��Đ�قǂ̕�����̃��[�J���ϐ���\��
        Debug.Log($"3������,����ꂽ���� : {b}");
        Debug.Log($"�p�[�Z���g�ɒ��������� : {d}");
    }
}

using UnityEngine;

/// <summary>
/// �ėp�I�Ɏg������(�����ł͈��������ꂼ��̗p�r�ɍ������\�L������������ɕϊ����邽�߂̏���)
/// </summary>
public static class UIUtility
{
    /// <summary>
    /// 3�����ƂɁu,�v��}������������𐶐����郁�\�b�h(�C���X�^���X�����Ȃ�����static������)
    /// </summary>
    public static string NumberFormatter(int number)
    {
        //������3������R���}����ꂽ������ɕϊ����ĕԂ�
        return number.ToString("#,0");
    }

    /// <summary>
    /// ���l���p�[�Z���g�\���ɕύX���郁�\�b�h(�C���X�^���X�����Ȃ�����static������)
    /// </summary>
    public static string ConvertPercent(float ratio)
    {
        //������100�Ŋ��������l�����[�J���ϐ��Ƃ��Đ���
        float convertRatio = ratio * 100.0f;

        //���������l�������_���ʂ܂ł�\������������ɂ����𖖔��ɂ�����Ԃ̕������Ԃ�
        return convertRatio.ToString("F2") + "%";
    }
}

//static�̓A�N�Z�X�����u�Ԃɐ��������

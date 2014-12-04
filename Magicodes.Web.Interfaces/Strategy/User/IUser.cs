using System;
using System.Collections.Generic;

namespace Magicodes.Web.Interfaces.Strategy.User
{
    public interface IUser
    {
        int Id { get; set; }
        /// <summary>
        /// ��¼��
        /// </summary>
        string LoginName { get; set; }
        /// <summary>
        /// �û������ǳ�
        /// </summary>        
        string UserNickName { get; set; }
        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        bool Deleted { get; set; }
        /// <summary>
        /// �Ƿ��Ѿ�����
        /// </summary>
        bool IsActive { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        string Email { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        DateTimeOffset CreateTime { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        string Password { get; set; }
        /// <summary>
        /// ��ǰ����
        /// </summary>
        string Theme { get; set; }
        /// <summary>
        /// ����½ʱ��
        /// </summary>
        DateTimeOffset? LastLoginTime { get; set; }
        /// <summary>
        /// ͷ��
        /// </summary>
        string HeadPortrait { get; set; }
    }
}

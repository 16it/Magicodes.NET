using System;
using System.Collections.Generic;

namespace Magicodes.Web.Interfaces.Strategy.User
{
    /// <summary>
    /// �û�
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IUser<out TKey>
    {
        /// <summary>
        /// �û�Id
        /// </summary>
        TKey Id { get; }
        /// <summary>
        /// ��ʾ�����ǳ�
        /// </summary>
        string DisplayName { get; set; }
        /// <summary>
        /// �û���
        /// </summary>
        string UserName { get; set; }
    }
}

using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ͼƬ����
    /// </summary>
    public partial class CMS_PhotoClass : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ͼƬ��������
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        public Nullable<int> ParentId { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public Nullable<int> Sequence { get; set; }
    }
}

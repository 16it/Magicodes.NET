using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ����
    /// </summary>
    public partial class CMS_Comment : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ����Id
        /// </summary>
        public int ContentId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// �ظ���
        /// </summary>
        public int ReplyCount { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        public int? ParentID { get; set; }
    }
}

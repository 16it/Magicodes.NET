using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.CMS.Models
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
        [MaxLength(1000)]
        public string Comment { get; set; }
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

using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.CMS.Models
{
    /// <summary>
    /// ����
    /// </summary>
    public partial class CMS_Content : CMS_ContentTypeBase
    {
        /// <summary>
        /// ����
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// ��̬����
        /// </summary>
        [MaxLength(300)]
        public string StaticUrl { get; set; }
    }
}

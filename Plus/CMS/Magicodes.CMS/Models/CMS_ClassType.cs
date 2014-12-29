using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magicodes.CMS.Models
{
    /// <summary>
    /// ��Ŀ����
    /// </summary>
    public partial class CMS_ClassType : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ��������
        /// </summary>
        [MaxLength(50)]
        public string ClassTypeName { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        public Nullable<int> ParentId { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public Nullable<int> Sequence { get; set; }
        /// <summary>
        /// �Ƿ���������
        /// </summary>
        public bool AllowComments { get; set; }
        /// <summary>
        /// ͼƬ
        /// </summary>
        [MaxLength(300)]
        public string ImageUrl { get; set; }
        /// <summary>
        /// ����ͼ
        /// </summary>
        [MaxLength(300)]
        public string ThumbImageUrl { get; set; }
        /// <summary>
        /// ��ͨͼƬ
        /// </summary>
        [MaxLength(300)]
        public string NormalImageUrl { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public CMS_ContentTypes ContentType { get; set; }
        /// <summary>
        /// �Ƿ��Զ����ɾ�̬ҳ
        /// </summary>
        public bool IsAutoGenerateStaticPages { get; set; }
    }
}

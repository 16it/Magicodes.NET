using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ��������
    /// </summary>
    public partial class CMS_ContentClass : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ����
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int Sequence { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        public Nullable<int> ParentId { get; set; }
        /// <summary>
        /// �Ƿ������Ӽ�
        /// </summary>
        public bool AllowSubclass { get; set; }
        /// <summary>
        /// �Ƿ������������
        /// </summary>
        public bool AllowAddContent { get; set; }
        /// <summary>
        /// ͼƬ��ַ
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// �ؼ���
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// ��Ŀ���
        /// </summary>
        public int ClassTypeID { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remark { get; set; }

        public string Meta_Title { get; set; }
        public string Meta_Description { get; set; }
        public string Meta_Keywords { get; set; }
        public string SeoUrl { get; set; }
        public string SeoImageAlt { get; set; }
        public string SeoImageTitle { get; set; }
    }
}

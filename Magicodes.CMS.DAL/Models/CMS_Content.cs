using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ����
    /// </summary>
    public partial class CMS_Content : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ����
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// �ӱ���
        /// </summary>
        public string SubTitle { get; set; }
        /// <summary>
        /// ���
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// ��ϸ����
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ͼƬ
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// ����ͼ
        /// </summary>
        public string ThumbImageUrl { get; set; }
        /// <summary>
        /// ��ͨͼƬ
        /// </summary>
        public string NormalImageUrl { get; set; }
        /// <summary>
        /// �������ӵ�ַ
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int PvCount { get; set; }
        /// <summary>
        /// ״̬
        /// </summary>
        public short State { get; set; }
        /// <summary>
        /// Ƶ������
        /// </summary>
        public int ClassID { get; set; }
        /// <summary>
        /// �ؼ���
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int Sequence { get; set; }
        /// <summary>
        /// �Ƽ�
        /// </summary>
        public bool IsRecomend { get; set; }
        /// <summary>
        /// �ȵ�
        /// </summary>
        public bool IsHot { get; set; }
        /// <summary>
        /// ��Ŀ
        /// </summary>
        public bool IsColor { get; set; }
        /// <summary>
        /// �ö�
        /// </summary>
        public bool IsTop { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Attachment { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Remary { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int TotalComment { get; set; }
        /// <summary>
        /// ֧����
        /// </summary>
        public int TotalSupport { get; set; }
        /// <summary>
        /// ϲ����
        /// </summary>
        public int TotalFav { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int TotalShare { get; set; }
        /// <summary>
        /// ��Դ
        /// </summary>
        public string BeFrom { get; set; }
        public string FileName { get; set; }
        public string Meta_Title { get; set; }
        public string Meta_Description { get; set; }
        public string Meta_Keywords { get; set; }
        public string SeoUrl { get; set; }
        public string SeoImageAlt { get; set; }
        public string SeoImageTitle { get; set; }
        public string StaticUrl { get; set; }
    }
}

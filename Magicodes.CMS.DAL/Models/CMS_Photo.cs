using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ͼƬ
    /// </summary>
    public partial class CMS_Photo : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ͼƬ����
        /// </summary>
        public string PhotoName { get; set; }
        /// <summary>
        /// ͼƬ
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ͼƬר��Id
        /// </summary>
        public int AlbumID { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int PVCount { get; set; }
        /// <summary>
        /// ����Id
        /// </summary>
        public int ClassID { get; set; }
        /// <summary>
        /// ����ͼ
        /// </summary>
        public string ThumbImageUrl { get; set; }
        /// <summary>
        /// ����ͼ
        /// </summary>
        public string NormalImageUrl { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public Nullable<int> Sequence { get; set; }
        /// <summary>
        /// �Ƿ��Ƽ�
        /// </summary>
        public bool IsRecomend { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int CommentCount { get; set; }
        /// <summary>
        /// ��ǩ
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// ϲ����
        /// </summary>
        public int FavouriteCount { get; set; }
    }
}

using Magicodes.Web.Interfaces.Models;
using System;
using System.Collections.Generic;

namespace Magicodes.CMS.DAL.Models
{
    /// <summary>
    /// ͼƬר��
    /// </summary>
    public partial class CMS_PhotoAlbum : CommonBusinessModelBase<int, string>
    {
        /// <summary>
        /// ר������
        /// </summary>
        public string AlbumName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ������ƬId
        /// </summary>
        public Nullable<int> CoverPhoto { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int PVCount { get; set; }
        /// <summary>
        /// �����
        /// </summary>
        public int Sequence { get; set; }
    }
}

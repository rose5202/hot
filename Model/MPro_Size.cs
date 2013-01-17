using System;
using System.Collections.Generic;
using System.Linq;

namespace Rose.Model.Hot
{
    /// <summary>
    /// MPro_size:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MPro_size
    {
        public MPro_size()
        { }
        #region Model
        private int _sizeid_pk;
        private DateTime _rowdate = DateTime.Now;
        private bool _isshow = true;
        private string _sizedesc;
        private int _classid_fk;
        /// <summary>
        /// 
        /// </summary>
        public int SizeId_PK
        {
            set { _sizeid_pk = value; }
            get { return _sizeid_pk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime rowdate
        {
            set { _rowdate = value; }
            get { return _rowdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsShow
        {
            set { _isshow = value; }
            get { return _isshow; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SizeDesc
        {
            set { _sizedesc = value; }
            get { return _sizedesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ClassId_FK
        {
            set { _classid_fk = value; }
            get { return _classid_fk; }
        }
        #endregion Model

    }
}



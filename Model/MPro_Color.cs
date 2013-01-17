using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rose.Model.Hot
{
    /// <summary>
    /// Pro_color:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Pro_color
    {
        public Pro_color()
        { }
        #region Model
        private int _colorid_pk;
        private string _colordesc;
        private DateTime _rowdate = DateTime.Now;
        private bool _isshow = true;
        /// <summary>
        /// 
        /// </summary>
        public int ColorId_PK
        {
            set { _colorid_pk = value; }
            get { return _colorid_pk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ColorDesc
        {
            set { _colordesc = value; }
            get { return _colordesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime RowDate
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
        #endregion Model

    }
}


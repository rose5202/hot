using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Rose.Model.Hot
{
    /// <summary>
    /// MPro_commend:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MPro_commend
    {
        public MPro_commend()
        { }
        #region Model
        private int _commendid_pk;
        private string _commend;
        private DateTime _rowdate = DateTime.Now;
        private int _productid_fk;
        private bool _isshow = false;
        private int _userid_fk;
        /// <summary>
        /// 
        /// </summary>
        public int CommendId_PK
        {
            set { _commendid_pk = value; }
            get { return _commendid_pk; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Commend
        {
            set { _commend = value; }
            get { return _commend; }
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
        public int ProductId_FK
        {
            set { _productid_fk = value; }
            get { return _productid_fk; }
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
        public int UserId_Fk
        {
            set { _userid_fk = value; }
            get { return _userid_fk; }
        }
        #endregion Model

    }
}


